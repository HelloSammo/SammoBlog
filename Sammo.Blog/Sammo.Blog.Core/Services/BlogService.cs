using Sammo.Blog.Core.Interfaces;
using System.Threading.Tasks;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Common;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System.Collections.Generic;
using System;
using Sammo.Blog.Repository.General.Interfaces;

namespace Sammo.Blog.Core.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly ITagRepository _tagRepository;
        public BlogService(IBlogRepository blogRepository, ITagRepository tagRepository)
        {
            _blogRepository = blogRepository;
            _tagRepository = tagRepository;
        }

        public async Task<bool> AddAsync(BlogEntity blog)
        {
            Requires.NotNull(blog, nameof(blog));
            if (!await _blogRepository.AddAsync(blog))
                return false;

            return true;
        }

        public Task<IPagedList<BlogEntity>> GetAsync(int pageIndex, int pageSize)
        {
            return _blogRepository.GetBlogsAsync(pageIndex, pageSize);
        }
    }
}
