﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Models
{
    public class UserViewModel
    {
        [EmailAddress]
        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        [StringLength(32)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, MinimumLength =5)]
        public string Password { get; set; }

        public string Id { get; set; }
        
    }
}
