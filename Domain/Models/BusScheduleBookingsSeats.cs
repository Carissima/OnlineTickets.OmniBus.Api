using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBookingsSeats
    {
        public uint Id { get; set; }
        public int? BookingId { get; set; }
        public int? SeatId { get; set; }
        public int? TicketId { get; set; }
        public int? StartLocationId { get; set; }
        public int? EndLocationId { get; set; }
        public string IsReturn { get; set; }
    }
}
