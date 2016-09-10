using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class CommentRepository : DbContextService<EntityBase>,ICommentRepository
    {
        public Task<bool> AddAsync(CommentEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(CommentEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommentEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CommentEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountCommentsByBlogAsync(BlogEntity blog)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountCommentsByUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
