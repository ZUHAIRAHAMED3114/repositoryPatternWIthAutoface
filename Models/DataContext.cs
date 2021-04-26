using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("sportsStoreDb")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}