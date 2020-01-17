using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePluginLocaleLanguages
    {
        public uint Id { get; set; }
        public string Iso { get; set; }
        public string Title { get; set; }
        public string Region { get; set; }
        public string Native { get; set; }
        public string Dir { get; set; }
        public string CountryAbbr { get; set; }
        public string LanguageAbbr { get; set; }
        public string File { get; set; }
    }
}
