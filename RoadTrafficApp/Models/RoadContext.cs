using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RoadTrafficApp.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RoadTrafficApp.Models
{
    public class RoadContext : DbContext
    {
        public RoadContext() : base("RoadContext")
        {

        }

        public DbSet<Toll> Tolls { get; set; }
        public DbSet<Vehicle> Vechicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}