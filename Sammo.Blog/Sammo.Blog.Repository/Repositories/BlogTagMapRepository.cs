using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class BlogTagMapRepository : DbContextService, IBlogTagMapRepository
    {
        //public async Task<bool> AddAsync(BlogTagMapEntity entity)
        //{
        //    var result = DbContext.Set<BlogTagMapEntity>().Add(entity);
        //    if (result == null)
        //        return false;

        //    await DbContext.SaveChangesAsync();
        //    return true;
        //}
    }
}
