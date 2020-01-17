using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusScheduleUsers
    {
        public uint Id { get; set; }
        public uint RoleId { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Status { get; set; }
        public string IsActive { get; set; }
        public string Ip { get; set; }
    }
}
