using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Sammo.Blog.Repository.EntityFramework;

namespace Sammo.Blog.Repository.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly BlogDbContext _context;
        private readonly IDbTransaction _transaction;
        private readonly ObjectContext _objectContext;

        public UnitOfWork(BlogDbContext context)
        {
            _context = context;

            _objectContext = ((IObjectContextAdapter)_context).ObjectContext;

            if (_objectContext.Connection.State != ConnectionState.Open)
            {
                _objectContext.Connection.Open();
                _transaction = _objectContext.Connection.BeginTransaction();
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();

            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                }
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void AutoDetectChangesEnabled(bool option)
        {
            _context.Configuration.AutoDetectChangesEnabled = option;
        }

        public void LazyLoadingEnabled(bool option)
        {
            _context.Configuration.LazyLoadingEnabled = option;
        }

        public void Dispose()
        {
            if (_objectContext.Connection.State == ConnectionState.Open)
            {
                _objectContext.Connection.Close();
            }
        }
    }
}
