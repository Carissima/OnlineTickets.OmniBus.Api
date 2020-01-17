using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleFields
    {
        public uint Id { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public string Source { get; set; }
        public DateTime? Modified { get; set; }
    }
}
