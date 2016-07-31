using Sammo.Blog.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T t);

        Task<bool> UpdateAsync(T t);

        Task<bool> DeleteAsync(T t);

        Task<IEnumerable<T>> GetAllAsync();
    }
}
