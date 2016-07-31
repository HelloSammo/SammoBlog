using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class TagRepository : DbContextService,ITagRepository
    {
        public Task<bool> AddAsync(TagEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TagEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TagEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TagEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
