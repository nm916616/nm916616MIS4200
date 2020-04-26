using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace nm916616MIS4200.Models
{
    public class Pets
    {
        [Key]
        public int petID { get; set; }
        [Display(Name = "Pet Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Name required")]
        public string petName { get; set; }
        [Display(Name = "Breed")]
        [StringLength(20)]
        [Required(ErrorMessage = "Breed required")]
        public string petType { get; set; }
        [Display(Name = "Patient Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        [Required(ErrorMessage = "Required")]
        public DateTime patientSince { get; set; }
        public ICollection<Owners> Owners { get; set; }

    }
}