using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleSeats
    {
        public uint Id { get; set; }
        public uint? BusTypeId { get; set; }
        public ushort? Width { get; set; }
        public ushort? Height { get; set; }
        public ushort? Top { get; set; }
        public ushort? Left { get; set; }
        public string Name { get; set; }
    }
}
