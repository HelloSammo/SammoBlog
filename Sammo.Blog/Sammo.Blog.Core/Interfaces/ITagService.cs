using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Core.Interfaces
{
    public interface ITagService
    {
        Task<bool> AddAsync(string tagNameString, UserEntity author);

        Task<bool> IsExistsAsync(string tagName);

        Task<TagEntity> GetTagByNameAsync(string tagName);

        Task<IEnumerable<TagEntity>> QueryAsync(Expression<Func<TagEntity, bool>> filter);
    }
}
