using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}