using Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public class ProductTypeRepository : IProductTypeRepository, IDisposable
    {
        private bool disposed = false;
        private readonly StoreContext _context;
        
        public ProductTypeRepository(StoreContext context)
        {
            _context = context;
        }
        public void Delete(int productTypeId)
        {
            ProductType productType = _context.ProductTypes.Find(productTypeId);
            _context.ProductTypes.Remove(productType);
        }

        public IEnumerable<ProductType> ProductTypes()
        {
            return _context.ProductTypes;
        }

        public ProductType GetByID(int productTypeId)
        {
            return _context.ProductTypes.Find(productTypeId);
        }

        public void Insert(ProductType productType)
        {
            _context.ProductTypes.Add(productType);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ProductType productType)
        {
            _context.Entry(productType).State = EntityState.Modified;
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
