using Services.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IOmnibusService
    {
        IEnumerable<Route> ListRoutes();
        IEnumerable<Bus> ListBuses(ListBusesRequest request);
    }
}
