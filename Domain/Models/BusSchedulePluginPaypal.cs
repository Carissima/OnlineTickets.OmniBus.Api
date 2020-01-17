using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePluginPaypal
    {
        public uint Id { get; set; }
        public uint? ForeignId { get; set; }
        public string SubscrId { get; set; }
        public string TxnId { get; set; }
        public string TxnType { get; set; }
        public decimal? McGross { get; set; }
        public string McCurrency { get; set; }
        public string PayerEmail { get; set; }
        public DateTime? Dt { get; set; }
    }
}
