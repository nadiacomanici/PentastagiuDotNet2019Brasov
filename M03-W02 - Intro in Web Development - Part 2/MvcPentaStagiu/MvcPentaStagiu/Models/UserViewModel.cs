using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPentaStagiu.Models
{
    public class UserViewModel
    {
        public long Id { get; set; }
        [Required]
        [Display(Name = "Prenume")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
