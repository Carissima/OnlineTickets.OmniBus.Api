using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePrices
    {
        public uint Id { get; set; }
        public uint? BusId { get; set; }
        public uint? TicketId { get; set; }
        public int? FromLocationId { get; set; }
        public int? ToLocationId { get; set; }
        public decimal? Price { get; set; }
        public string IsReturn { get; set; }
    }
}
