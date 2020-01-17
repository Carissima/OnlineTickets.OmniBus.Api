using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBusTypes
    {
        public uint Id { get; set; }
        public string SeatsMap { get; set; }
        public int? SeatsCount { get; set; }
        public string Status { get; set; }
    }
}
