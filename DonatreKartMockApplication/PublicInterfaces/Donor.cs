﻿using System;

namespace DonatreKartMockApplication.PublicInterfaces
{
    public class Donor : IDonor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
