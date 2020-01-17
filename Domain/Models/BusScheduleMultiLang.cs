using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleMultiLang
    {
        public uint Id { get; set; }
        public uint? ForeignId { get; set; }
        public string Model { get; set; }
        public byte? Locale { get; set; }
        public string Field { get; set; }
        public string Content { get; set; }
        public string Source { get; set; }
    }
}
