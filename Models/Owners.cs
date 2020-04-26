using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace nm916616MIS4200.Models
{
    public class Owners
    {
        [Key]
        public int ownerID { get; set; }
        [Display(Name = "First Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "First Name required")]
        public string ownerFirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Last Name required")]
        public string ownerLastName { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number required")]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{4}$",
            ErrorMessage = "Phone numbers must be in format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email required")]
        
        public string email { get; set; }
        [Display(Name = "Home Address")]
        [Required(ErrorMessage = "Home Address required")]
        public string address { get; set; }
        [Display(Name = "Pet Name")]
        [Required(ErrorMessage = "Pet Name required")]
        public int petID { get; set; }
        public virtual Pets Pets { get; set; }
        [Display(Name = "Vet Name")]
        [Required(ErrorMessage = "Vet Name required")]
        public int vetID { get; set; }
        public virtual Vets Vets { get; set; }
    }
}