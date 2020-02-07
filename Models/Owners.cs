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
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int petID { get; set; }
        public virtual Pets Pets { get; set; }
        public int vetID { get; set; }
        public virtual Vets Vets { get; set; }
    }
}