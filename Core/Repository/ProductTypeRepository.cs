using Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
    {
        private readonly StoreContext _context;
        
        public ProductTypeRepository(StoreContext context) : base(context)
        {
            _context = context;
        }
    }
}
