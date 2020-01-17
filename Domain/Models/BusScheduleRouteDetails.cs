using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleRouteDetails
    {
        public uint Id { get; set; }
        public uint? RouteId { get; set; }
        public int? FromLocationId { get; set; }
        public int? ToLocationId { get; set; }
    }
}
