using Sammo.Blog.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories.Interfaces
{
    public interface ITagRepository
    {
        //Task<IEnumerable<TagEntity>> GetTags();

        //Task<bool> AddTag();

        Task<bool> BulkAddAsync(IEnumerable<TagEntity> tags);

        Task<bool> IsExistsAsync(string name);

        Task<TagEntity> GetTagByNameAsync(string tagName);

        Task<TagEntity> AddTagAsync(TagEntity tag);

        Task<IEnumerable<TagEntity>> QueryAsync(Expression<Func<TagEntity, bool>> filter);
    }
}
