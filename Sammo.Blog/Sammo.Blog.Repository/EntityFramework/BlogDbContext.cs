using Sammo.Blog.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.EntityFramework
{
    public class BlogDbContext:DbContext,IDbContext
    {
        public BlogDbContext() : base("DbConnection") { }

        public IDbSet<UserEntity> User { get; set; }
        public IDbSet<BlogEntity> Article { get; set; }
        public IDbSet<CommentEntity> Comment { get; set; }
        public IDbSet<TagEntity> Tag { get; set; }
        public IDbSet<CategoryEntity> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new UserMapping());

            base.OnModelCreating(modelBuilder);
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        
    }
}
