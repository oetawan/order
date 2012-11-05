using Order.Data.Configuration;
using Order.Data.SampleData;
using Order.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext() : base(nameOrConnectionString: "Order")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        static OrderDbContext()
        {
            Database.SetInitializer(new OrderDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }
    }
}
