using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePluginLog
    {
        public uint Id { get; set; }
        public string Filename { get; set; }
        public string Function { get; set; }
        public string Value { get; set; }
        public DateTime? Created { get; set; }
    }
}
