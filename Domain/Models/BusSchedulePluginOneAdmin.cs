﻿using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class BusSchedulePluginOneAdmin
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
    }
}
