using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePluginSms
    {
        public uint Id { get; set; }
        public string Number { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public DateTime? Created { get; set; }
    }
}
