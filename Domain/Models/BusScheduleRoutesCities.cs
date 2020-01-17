using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleRoutesCities
    {
        public uint Id { get; set; }
        public uint? RouteId { get; set; }
        public uint? CityId { get; set; }
        public sbyte? Order { get; set; }
    }
}
