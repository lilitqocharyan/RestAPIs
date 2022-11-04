﻿using Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        private bool disposed = false;
        private readonly StoreContext _context;
        
        public CategoryRepository(StoreContext context)
        {
            _context = context;
        }
        public void Delete(int categoryId)
        {
            Category category = _context.category.Find(categoryId);
            _context.category.Remove(category);
        }

        public IEnumerable<Category> Categories()
        {
            return _context.category;
        }

        public Category GetByID(int categoryId)
        {
            return _context.category.Find(categoryId);
        }

        public void Insert(Category category)
        {
            _context.category.Add(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
