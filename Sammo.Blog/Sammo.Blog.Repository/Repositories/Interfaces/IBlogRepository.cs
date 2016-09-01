using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.General.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories.Interfaces
{
    public interface IBlogRepository
    {
        Task<bool> AddAsync(BlogEntity blog);
        Task<IEnumerable<BlogEntity>> GetBlogsByCreationTimeAsync(int count);

        Task<IEnumerable<BlogEntity>> GetAllBlogsByIdAsync();

        Task<IEnumerable<string>> GetAllTitleByCreationTimeAsync();

        Task<BlogEntity> GetBlogByIdAsync(string id);

        Task<IEnumerable<BlogEntity>> GetTitleByCreationTimeAsync(int count);

        Task<IEnumerable<BlogEntity>> GetBlogsByCategoryAsync(string categoryId);

        Task<IEnumerable<BlogEntity>> GetBlogsByTagAsync(string tagId);

        Task<IPagedList<BlogEntity>> GetBlogsAsync(int pageIndex, int pageSize);
    }
}
