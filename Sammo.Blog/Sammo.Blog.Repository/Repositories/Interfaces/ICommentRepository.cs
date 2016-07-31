using Sammo.Blog.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories.Interfaces
{
    public interface ICommentRepository : IRepository<CommentEntity>
    {
        Task<int> CountCommentsByBlogAsync(BlogEntity blog);

        Task<int> CountCommentsByUserAsync(UserEntity user);
    }
}
