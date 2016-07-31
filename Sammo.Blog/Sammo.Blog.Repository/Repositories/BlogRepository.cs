using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class BlogRepository: DbContextService, IBlogRepository
    {
        public Task<bool> AddAsync(BlogEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(BlogEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(BlogEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogEntity>> GetAllBlogsByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetAllTitleByCreationTimeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogEntity> GetBlogByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogEntity>> GetBlogsByCategoryAsync(string categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogEntity>> GetBlogsByCreationTimeAsync(int count)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogEntity>> GetBlogsByTagAsync(string tagId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogEntity>> GetTitleByCreationTimeAsync(int count)
        {
            throw new NotImplementedException();
        }
    }
}
