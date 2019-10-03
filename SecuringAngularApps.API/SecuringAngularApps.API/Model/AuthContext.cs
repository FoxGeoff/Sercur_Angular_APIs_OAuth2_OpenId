﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecuringAngularApps.API.Model
{
    public class AuthContext
    {
        public UserProfile UserProfile { get; set; }
        public List<SimpleClaim> SimpleClaims { get; set; }
    }
}
