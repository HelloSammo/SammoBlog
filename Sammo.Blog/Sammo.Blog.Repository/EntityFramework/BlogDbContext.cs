using Sammo.Blog.Repository.Entities;
using System.Data.Entity;

namespace Sammo.Blog.Repository.EntityFramework
{
    public class BlogDbContext: DbContext,  IDbContext
    {
        public BlogDbContext() : base("DbConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>("DbConnection"));
        }
        public IDbSet<UserEntity> User { get; set; }
        public IDbSet<BlogEntity> Article { get; set; }
        public IDbSet<CommentEntity> Comment { get; set; }
        public IDbSet<TagEntity> Tag { get; set; }
        public IDbSet<CategoryEntity> Category { get; set; }
        //public IDbSet<BlogTagMapEntity> BlogTagMap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var user = modelBuilder.Entity<UserEntity>();
            user.HasMany(u => u.Tags).WithRequired(t => t.Author).HasForeignKey(t => t.AuthorId).WillCascadeOnDelete(false);
            user.HasMany(u => u.Blogs).WithRequired(b => b.Author).HasForeignKey(b => b.AuthorId).WillCascadeOnDelete(false);
            user.HasMany(u => u.Comments).WithRequired(c => c.Author).HasForeignKey(c => c.AuthorId).WillCascadeOnDelete(false);

            var blog = modelBuilder.Entity<BlogEntity>();
            blog.HasMany(b => b.Tags).WithMany(b => b.Blogs).Map(b => b.ToTable("BlogTagMap"));
            base.OnModelCreating(modelBuilder);
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        
    }
}
