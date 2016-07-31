using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class CategoryRepository : DbContextService,ICategoryRepository
    {
        public Task<bool> AddAsync(CategoryEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(CategoryEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CategoryEntity t)
        {
            throw new NotImplementedException();
        }


    }
}
