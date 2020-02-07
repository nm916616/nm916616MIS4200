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
        public string petName { get; set; }
        public string petType { get; set; }
        public DateTime patientSince { get; set; }
        public ICollection<Owners> Owners { get; set; }

    }
}