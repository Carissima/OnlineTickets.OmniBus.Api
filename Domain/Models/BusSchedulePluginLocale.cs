using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePluginLocale
    {
        public uint Id { get; set; }
        public string LanguageIso { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public string Dir { get; set; }
        public uint? Sort { get; set; }
        public byte? IsDefault { get; set; }
    }
}
