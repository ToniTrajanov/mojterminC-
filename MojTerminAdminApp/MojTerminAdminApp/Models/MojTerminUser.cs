﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MojTerminAdminApp.Models
{
    public class MojTerminUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }

        public string Email { get; set; }

        public string NormalizedUserName { get; set; }
    }
}
