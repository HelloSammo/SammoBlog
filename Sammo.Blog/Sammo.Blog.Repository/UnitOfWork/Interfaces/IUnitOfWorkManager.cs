using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.UnitOfWork
{
    public interface IUnitOfWorkManager:IDisposable
    {
        IUnitOfWork NewUnitOfWork();
    }
}
