using Sammo.Blog.Repository.EntityFramework;
using System.Data.Entity;

namespace Sammo.Blog.Repository.UnitOfWork
{
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        private bool _isDisposed;
        private readonly BlogDbContext _context;

        public UnitOfWorkManager(IDbContext context)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Migrations.Configuration>(Common.BlogConstants.Setting.BlogDbConnection));
            _context = context as BlogDbContext;
        }
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _context.Dispose();
                _isDisposed = true;
            }
        }

        public IUnitOfWork NewUnitOfWork()
        {
            return new UnitOfWork(_context);
        }
    }
}
