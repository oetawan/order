using Order.Data.Contract;
using Order.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Data
{
    public class OrderUow : IOrderUow
    {
        private OrderDbContext DbContext { get; set; }
        public OrderUow()
        {
            CreateDbContext();
            CreateRepositories();
        }

        private void CreateDbContext()
        {
            this.DbContext = new OrderDbContext();
            this.DbContext.Configuration.ProxyCreationEnabled = false;
            this.DbContext.Configuration.LazyLoadingEnabled = false;
            this.DbContext.Configuration.ValidateOnSaveEnabled = false;
        }

        private void CreateRepositories()
        {
            this.Categories = new EFRepository<Category>(this.DbContext);
            this.Products = new EFRepository<Product>(this.DbContext);
        }

        public IRepository<Model.Category> Categories { get; private set; }

        public IRepository<Model.Product> Products { get; private set; }

        public void Commit()
        {
            this.DbContext.SaveChanges();
        }
    }
}