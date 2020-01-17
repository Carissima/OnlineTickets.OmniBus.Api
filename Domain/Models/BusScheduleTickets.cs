using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleTickets
    {
        public uint Id { get; set; }
        public uint? BusId { get; set; }
        public uint? SeatsCount { get; set; }
    }
}
