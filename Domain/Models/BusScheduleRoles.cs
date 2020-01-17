using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleRoles
    {
        public byte Id { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
    }
}
