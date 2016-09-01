using Sammo.Blog.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<bool> AddAsync(CategoryEntity category);
        Task<bool> IsCategoryExistsAsync(string categoryName);
        Task<IEnumerable<CategoryEntity>> GetAllAsync();
    }
}
