using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nm916616MIS4200.Models
{
    public class Orders
    {
        [Key]
        public int orderNumb { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }




    }
}