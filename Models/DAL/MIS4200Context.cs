using System;
using System.Collections.Generic;
using System.Data.Entity;
using nm916616MIS4200.Models;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace nm916616MIS4200.Models.DAL
{
    public class MIS4200Context : DbContext
    {

        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,nm916616MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Vets> Vets { get; set; }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<Owners> Owners { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }


    }
}