using Sammo.Blog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Sammo.Blog.Core.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        
        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
            
        }
        public async Task<bool> AddAsync(string tagNameString,UserEntity author)
        {
            if (!string.IsNullOrEmpty(tagNameString))
            {
                var tagNames = tagNameString.Split(',');
                TagEntity tag = null;
                foreach (var tagName in tagNames)
                {
                    if (!await _tagRepository.IsExistsAsync(tagName))
                        tag = await _tagRepository.AddTagAsync(new TagEntity { Name = tagName, Author = author });
                }
            }
            return true;
        }

        public Task<TagEntity> GetTagByNameAsync(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistsAsync(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TagEntity>> QueryAsync(Expression<Func<TagEntity, bool>> filter)
        {
            return _tagRepository.QueryAsync(filter);
        }
    }
}
