using Sammo.Blog.Repository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository
{
    public class DbContextService
    {
        protected IDbContext _DbContext;
        public IDbContext DbContext
        {
            get
            {
                if (_DbContext == null)
                {
                    _DbContext = new BlogDbContext();
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
