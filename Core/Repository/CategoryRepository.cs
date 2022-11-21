using Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly StoreContext _context;

        public CategoryRepository(StoreContext context) : base(context)
        {
            _context = context;
        }
    }
}
