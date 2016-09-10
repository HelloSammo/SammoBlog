using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
        void Rollback();
        void SaveChanges();
        void AutoDetectChangesEnabled(bool option);
        void LazyLoadingEnabled(bool option);
    }
}
