using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBusesDates
    {
        public uint Id { get; set; }
        public uint? BusId { get; set; }
        public DateTime? Date { get; set; }
    }
}
