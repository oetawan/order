using Order.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Data.Contract
{
    public interface IOrderUow
    {
        IRepository<Category> Categories { get; }
        IRepository<Product> Products { get; }
        void Commit();
    }
}