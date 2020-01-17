using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBookingsPayments
    {
        public uint Id { get; set; }
        public uint? BookingId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
    }
}
