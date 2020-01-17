using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePluginCountry
    {
        public uint Id { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string Status { get; set; }
    }
}
