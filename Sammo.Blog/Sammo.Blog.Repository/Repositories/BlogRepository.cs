using Sammo.Blog.Common;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sammo.Blog.Repository.General.Interfaces;
using System.Linq;
using System.Data.Entity;
using Sammo.Blog.Repository.General;

namespace Sammo.Blog.Repository.Repositories
{
    public class BlogRepository: DbContextService, IBlogRepository
    {
        public async Task<bool> AddAsync(BlogEntity blog)
        {
            Requires.NotNull(blog, nameof(blog));
            var result = DbContext.Set<BlogEntity>().Add(blog);
            if(result != null)
            {
                //DbContext.Entry<BlogEntity>(result).State = EntityState.Detached;
                await DbContext.SaveChangesAsync();
                
                return true;
            }
            return false;
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

        public async Task<IPagedList<BlogEntity>> GetBlogsAsync(int pageIndex, int pageSize)
        {
            var totalCount = DbContext.Set<BlogEntity>().Count();
            //var result = await DbContext.Set<BlogEntity>().Include(b=>b.Author).Include(b=>b.Category).Include(b=>b.Tags)
            //            .Include(b=>b.Comments).AsNoTracking().OrderByDescending(b => b.IsTop).ThenByDescending(b => b.CreateTime)
            //            .Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            var result = await DbContext.Set<BlogEntity>()
                        .OrderByDescending(b => b.IsTop).ThenByDescending(b => b.CreateTime)
                        .Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<BlogEntity>(result, pageIndex, pageSize, totalCount); 
        }
    }
}
