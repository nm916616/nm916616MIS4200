using System;
using System.Collections.Generic;
using System.Data.Entity;
using nm916616MIS4200.Models;
using System.Linq;
using System.Web;

namespace nm916616MIS4200.Models.DAL
{
    public class MIS4200Context : DbContext
    {

        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customer { get; set; }

    }
}