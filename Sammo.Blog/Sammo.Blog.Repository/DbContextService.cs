using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.EntityFramework;
using System.Runtime.Remoting.Messaging;

namespace Sammo.Blog.Repository
{
    public class DbContextService<T> where T: EntityBase
    {
        private static object obj = new object();
        protected IDbContext _DbContext;
        public IDbContext DbContext
        {
            get
            {
                _DbContext = CallContext.GetData(typeof(T).Name) as IDbContext;
                if (_DbContext != null) return _DbContext as BlogDbContext;
                lock (obj)
                {
                    _DbContext = new BlogDbContext();
                    CallContext.SetData(typeof(T).Name, _DbContext);
                }

                return _DbContext as BlogDbContext;
            }
            
        }
    }
}
