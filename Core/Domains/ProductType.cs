using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domains
{
    public class ProductType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
