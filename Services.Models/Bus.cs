using System;

namespace Services.Models
{
    public class ListBusesRequest
    {
        public DateTime DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int FromStation { get; set; }
        public int ToStation { get; set; }
    }
    public class Bus
    {
        public string FromCity { get; set; }
        public uint? FromCityId { get; set; }
        public string ToCity { get; set; }
        public uint? ToCityId { get; set; }
        public TimeSpan? BusDepartureTime { get; set; }
        public TimeSpan? BusArrivalTime { get; set; }
    }
}
