using Sammo.Blog.Repository.EntityFramework;

namespace Sammo.Blog.Repository
{
    public class DbContextService
    {
        private static object obj = new object();
        protected IDbContext _DbContext;
        public IDbContext DbContext
        {
            get
            {
                if (_DbContext == null)
                {
                    lock(obj)
                    {
                        _DbContext = new BlogDbContext();
                    }
                    
                }

                return _DbContext;
            }
            set
            {
                _DbContext = value;
            }
        }
    }
}
