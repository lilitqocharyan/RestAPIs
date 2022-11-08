using Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private bool disposed = false;
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public void Delete(int productId)
        {
            Product product = _context.Products.Find(productId);
            _context.Products.Remove(product);
        }

        public Product GetByID(int productId)
        {
            return _context.Products.Find(productId);
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
        }

        public IEnumerable<Product> Products()
        {
            return _context.Products.Include(p => p.Category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
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
