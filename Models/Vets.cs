using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace nm916616MIS4200.Models
{
    public class Vets
    {
        [Key]
        public int vetID { get; set; }
        [Display(Name = "First Name")]
        [StringLength(20)]
        [Required(ErrorMessage ="First Name required")]
        public string vetFirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Last Name required")]
        public string vetLastName { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number required")]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{4}$",
             ErrorMessage = "Phone numbers must be in format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email required")]
        public string email { get; set; }
        public ICollection<Owners> Owners { get; set; }
    }
}