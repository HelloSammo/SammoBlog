using Sammo.Blog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Enums;
using Sammo.Blog.Repository.Repositories.Interfaces;
using Sammo.Blog.Common;

namespace Sammo.Blog.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<CategoryInvokeResult> AddCategoryAsync(CategoryEntity category)
        {
            Requires.NotNull(category, nameof(category));
            var result = await ValidateCategoryAsync(category);
            switch (result)
            {
                case CategoryInvokeResult.Success:
                    if (await _repository.AddAsync(category))
                        return CategoryInvokeResult.Success;
                    return CategoryInvokeResult.Failed;

                case CategoryInvokeResult.Exists:
                    return CategoryInvokeResult.Exists;

                case CategoryInvokeResult.InvalidName:
                    return CategoryInvokeResult.InvalidName;

                default:
                    return CategoryInvokeResult.Failed;
            }
        }

        public  Task<IEnumerable<CategoryEntity>> GetCategoriesAsync()
        {
            return  _repository.GetAllAsync();
        }

        public async Task<CategoryInvokeResult> ValidateCategoryAsync(CategoryEntity category)
        {
            if (category.Name.Length > BlogConstants.Validation.CategoryNameLength)
                return CategoryInvokeResult.InvalidName;

            if (await _repository.IsCategoryExistsAsync(category.Name))
                return CategoryInvokeResult.Exists;

            return CategoryInvokeResult.Success;
        }
    }
}
