
using System;

using EFDemo7.Repository;
using EFDemo7.EF;
using System.Transactions;
using EFDemo7.UnitOfWorks;
using EFDemo7.Entity;

namespace EFDemo7.UnitOfWorks
{
    public class ShopUnitOfWork  : IUnitOfWork
    {
        private ShopContext _context = new ShopContext();
        private ShopRepository<Category> _categoryRepository;
        private ShopRepository<Product> _productRepository;
        private bool _disposed = false;
        public ShopRepository<Category> CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new ShopRepository<Category>(_context);
                return _categoryRepository;
            }
        }
        public ShopRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ShopRepository<Product>(_context);
                return _productRepository;
            }
        }
        public void Save()
        {
            using (TransactionScope tScope = new TransactionScope())
            {
                _context.SaveChanges();
                tScope.Complete();
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}