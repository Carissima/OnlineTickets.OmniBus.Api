using Domain;
using Domain.Models;
using Services.Models;
using System.Linq;
using System.Collections.Generic;
using Common.Constants;
using System.Configuration;

namespace Services
{
    public class OmnibusService : IOmnibusService
    {
        OmnibusDbContext _db;
        public OmnibusService(OmnibusDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Route> ListRoutes()
        {
            return _db.Set<BusScheduleMultiLang>()
                            .Where(x => x.Model == ModelTypes.Route)
                            .ToList()
                            .GroupBy(x => x.ForeignId)
                            .Select(x => new Route
                            {
                                RouteId = x.Key,
                                From = x.First(f => f.Field == FieldNames.From).Content,
                                To = x.First(f => f.Field == FieldNames.To).Content,
                                Title = x.First(f => f.Field == FieldNames.Title).Content
                            });
        }

        public IEnumerable<Bus> ListBuses(ListBusesRequest request)
        {
            var result = new List<Bus>();
            var buses = _db.Set<BusScheduleBuses>().Where(x => x.StartDate <= request.DepartureDate && (!request.ReturnDate.HasValue || x.EndDate >= request.ReturnDate));
            foreach (var fb in buses)
            {
                var route = _db.Set<BusScheduleRoutes>().FirstOrDefault(x => x.Id == fb.RouteId && x.Status == Statuses.True);
                if (route != null)
                {
                    var routeDetails = from rd in _db.Set<BusScheduleRouteDetails>()
                                       join fbl in _db.Set<BusScheduleBusesLocations>() on (uint)rd.FromLocationId equals fbl.LocationId
                                       join tbl in _db.Set<BusScheduleBusesLocations>() on (uint)rd.ToLocationId equals tbl.LocationId
                                       join fc in _db.Set<BusScheduleMultiLang>() on (uint)rd.FromLocationId equals fc.ForeignId
                                       join tc in _db.Set<BusScheduleMultiLang>() on (uint)rd.ToLocationId equals tc.ForeignId
                                       where rd.RouteId == route.Id
                                           && fc.Model == ModelTypes.City && fc.Field == FieldNames.Name
                                           && tc.Model == ModelTypes.City && tc.Field == FieldNames.Name
                                           && fbl.DepartureTime.HasValue && tbl.ArrivalTime.HasValue
                                       select new Bus
                                       {
                                           FromCity = fc.Content,
                                           FromCityId = fc.ForeignId,
                                           BusDepartureTime = fbl.DepartureTime,
                                           ToCity = tc.Content,
                                           ToCityId = tc.ForeignId,
                                           BusArrivalTime = tbl.ArrivalTime
                                       };
                   
                    result = routeDetails.ToList();
                }
            }
            return result;
        }
    }
}
