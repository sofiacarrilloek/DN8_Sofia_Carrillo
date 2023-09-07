using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymManager.Core.MembershipTypes
{
    public class MembershipType
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Debe ingresar el nombre de la membresia")]
        public string Name { get; set; }
  
        [Required]
        public double Cost { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreateOn  { get; set; } = DateTime.Now;

        [Range(1, 100)]
        [Required]
        public int Duration { get; set; }

       }

}
