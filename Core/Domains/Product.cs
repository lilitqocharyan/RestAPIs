using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domains
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int ProductTypeID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductType ProductType { get; set; }

    }
}
