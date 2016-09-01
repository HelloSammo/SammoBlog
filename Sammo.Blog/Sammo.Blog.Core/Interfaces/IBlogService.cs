using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.General.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sammo.Blog.Core.Interfaces
{
    public interface IBlogService
    {
        Task<bool> AddAsync(BlogEntity blog);

        Task<IPagedList<BlogEntity>> GetAsync(int pageIndex, int pageSize);
    }
}
