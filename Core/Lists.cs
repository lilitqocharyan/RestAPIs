using Core.Domains;
using System;
using System.Collections.Generic;

namespace Core
{
    public class Lists
    {
        public static List<Category> categories = new List<Category>
        {
           new Category {ID=1,Name="SSS",Description="SSSS"},
           new Category {ID=2,Name="SSS",Description="SSSS"},
           new Category {ID=3,Name="SSS",Description="SSSS"},
           new Category {ID=4,Name="SSS",Description="SSSS"},
           new Category {ID=5,Name="SSS",Description="SSSS"},
        };

        public static List<Product> products = new List<Product>
        {
           new Product {ID=1,Name="SSS",Description="SSSS", Type=ProductType.Digital,Price=12.5,Category=new Category {ID=1,Name="SSS",Description="SSSS"}},
           new Product {ID=2,Name="SSS",Description="SSSS", Type=ProductType.Pyshical,Price=12.5,Category=new Category {ID=1,Name="SSS",Description="SSSS"}},
           new Product {ID=3,Name="SSS",Description="SSSS", Type=ProductType.Digital,Price=12.5,Category=new Category {ID=1,Name="SSS",Description="SSSS"}},
        };

    }
}
