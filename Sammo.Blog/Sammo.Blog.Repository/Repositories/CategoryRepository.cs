﻿using Sammo.Blog.Common;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class CategoryRepository : DbContextService<EntityBase>,ICategoryRepository
    {
        public async Task<bool> AddAsync(CategoryEntity category)
        {
            var result = DbContext.Set<CategoryEntity>().Add(category);
            if (result == null)
                return false;

            await DbContext.SaveChangesAsync();
            return true;
        }

        public Task<bool> DeleteAsync(CategoryEntity t)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryEntity>> GetAllAsync()
        {
            return await DbContext.Set<CategoryEntity>().OrderBy(c=>c.CreateTime).ToListAsync();
        }

        public Task<bool> IsCategoryExistsAsync(string categoryName)
        {
            return DbContext.Set<CategoryEntity>().AnyAsync(u => u.Name == categoryName);
        }

        public Task<bool> UpdateAsync(CategoryEntity t)
        {
            throw new NotImplementedException();
        }


    }
}
