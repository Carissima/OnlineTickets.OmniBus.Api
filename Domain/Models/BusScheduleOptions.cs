using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleOptions
    {
        public uint ForeignId { get; set; }
        public string Key { get; set; }
        public byte? TabId { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public uint? Order { get; set; }
        public byte? IsVisible { get; set; }
        public string Style { get; set; }
    }
}
