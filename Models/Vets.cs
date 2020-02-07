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
        public string vetFirstName { get; set; }
        public string vetLastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public ICollection<Owners> Owners { get; set; }
    }
}