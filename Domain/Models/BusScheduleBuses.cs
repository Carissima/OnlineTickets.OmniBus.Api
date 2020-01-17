using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBuses
    {
        public uint Id { get; set; }
        public uint? RouteId { get; set; }
        public uint? BusTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public string Recurring { get; set; }
        public string SetSeatsCount { get; set; }
        public decimal? Discount { get; set; }
    }
}
