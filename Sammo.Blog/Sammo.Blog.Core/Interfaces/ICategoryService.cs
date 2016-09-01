using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sammo.Blog.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryInvokeResult> AddCategoryAsync(CategoryEntity category);

        Task<CategoryInvokeResult> ValidateCategoryAsync(CategoryEntity category);

        Task<IEnumerable<CategoryEntity>> GetCategoriesAsync();
    }
}
