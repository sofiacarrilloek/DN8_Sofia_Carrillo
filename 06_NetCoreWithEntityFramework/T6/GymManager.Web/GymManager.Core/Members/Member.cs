﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Member
    {
        public int Id { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Debe ingresar el nombre del miembro")]
        public string Name { get; set; }

        [StringLength(20)]
        [Required]
        public string LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Range(1, 100)]
        public int CityId { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public bool AllowNewsletter { get; set; }
        public City City { get; set; }

        //public City City { get; set; } //public int City { get; set; }
    }
}
