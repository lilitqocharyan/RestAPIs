using Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context) : base(context)
        {
            _context = context;
        }
    }
}
