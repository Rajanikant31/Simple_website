using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment_3.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter Email Id")]
        public string EmailId { get; set; }
        [Required(ErrorMessage ="Enter Phone No.")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Plese select option")]
        public bool? willAttend { get; set; }
    }
}