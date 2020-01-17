using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBookingsTickets
    {
        public uint Id { get; set; }
        public int? BookingId { get; set; }
        public int? TicketId { get; set; }
        public int? Qty { get; set; }
        public decimal? Amount { get; set; }
        public string IsReturn { get; set; }
    }
}
