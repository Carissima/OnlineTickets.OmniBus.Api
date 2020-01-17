using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBusesLocations
    {
        public uint Id { get; set; }
        public uint? BusId { get; set; }
        public uint? LocationId { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
    }
}
