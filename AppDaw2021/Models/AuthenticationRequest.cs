﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDaw2021.Models
{
    public class AuthenticationRequest
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
