using Sammo.Blog.Common;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class TagRepository : DbContextService<EntityBase>, ITagRepository
    {
        public async Task<bool> AddAsync(TagEntity tag)
        {
            var result = DbContext.Set<TagEntity>().Add(tag);
            if (result == null)
                return false;
            //DbContext.Entry<TagEntity>(result).State = EntityState.Detached;
            await DbContext.SaveChangesAsync();
            return true;
        }

        public async Task<TagEntity> AddTagAsync(TagEntity tag)
        {
            var result = DbContext.Set<TagEntity>().Add(tag);
            if (result == null)
                return null;

            await DbContext.SaveChangesAsync();
            return result;
        }

        public async Task<bool> BulkAddAsync(IEnumerable<TagEntity> tags)
        {
            foreach (var tag in tags)
            {
                if (DbContext.Set<TagEntity>().Add(tag) != null)
                    await DbContext.SaveChangesAsync();

                return false;
            }
            return true;
        }

        public Task<bool> DeleteAsync(TagEntity t)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TagEntity>> GetAllAsync()
        {
            return await DbContext.Set<TagEntity>().OrderBy(t => t.CreateTime).ToListAsync();
        }

        public  Task<TagEntity> GetTagByNameAsync(string tagName)
        {
            return  DbContext.Set<TagEntity>().FirstOrDefaultAsync(t => t.Name == tagName);
        }

        public  Task<bool> IsExistsAsync(string name)
        {
            return  DbContext.Set<TagEntity>().AnyAsync(t => t.Name == name);
        }

        public Task<bool> UpdateAsync(TagEntity t)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TagEntity>> QueryAsync(Expression<Func<TagEntity, bool>> filter)
        {
            return await DbContext.Set<TagEntity>().AsNoTracking().Where(filter).ToListAsync();
        }
    }
}
