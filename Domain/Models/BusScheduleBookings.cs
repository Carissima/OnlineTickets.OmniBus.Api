using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleBookings
    {
        public uint Id { get; set; }
        public uint? Uuid { get; set; }
        public uint? BusId { get; set; }
        public uint? PickupId { get; set; }
        public uint? ReturnId { get; set; }
        public string IsReturn { get; set; }
        public uint? BackId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? BusDepartureDate { get; set; }
        public string BookingTime { get; set; }
        public string BookingRoute { get; set; }
        public DateTime? BookingDatetime { get; set; }
        public DateTime? StopDatetime { get; set; }
        public string Code { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Total { get; set; }
        public decimal? Deposit { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public string TxnId { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public DateTime? Created { get; set; }
        public string IsSent { get; set; }
        public string Ip { get; set; }
        public string CTitle { get; set; }
        public string CFname { get; set; }
        public string CLname { get; set; }
        public string CPhone { get; set; }
        public string CEmail { get; set; }
        public string CCompany { get; set; }
        public string CNotes { get; set; }
        public string CAddress { get; set; }
        public string CCity { get; set; }
        public string CState { get; set; }
        public string CZip { get; set; }
        public uint? CCountry { get; set; }
        public string CcType { get; set; }
        public string CcNum { get; set; }
        public string CcExp { get; set; }
        public string CcCode { get; set; }
    }
}
