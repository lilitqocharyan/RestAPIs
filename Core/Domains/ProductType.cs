using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domains
{
    public class ProductType
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
