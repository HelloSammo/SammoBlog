namespace Sammo.Blog.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blog",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false, maxLength: 30),
                        Article = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        PageViews = c.Int(nullable: false),
                        IsTop = c.Boolean(nullable: false),
                        AuthorId = c.String(nullable: false, maxLength: 128),
                        CategoryId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 128),
                        PasswordSalt = c.String(nullable: false, maxLength: 128),
                        Role = c.Byte(nullable: false),
                        AvatarId = c.String(maxLength: 36),
                        IsConfirmed = c.Boolean(nullable: false),
                        IsLocked = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreateTime = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 300),
                        BlogId = c.String(nullable: false, maxLength: 128),
                        AuthorId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.AuthorId)
                .ForeignKey("dbo.Blog", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 10),
                        CreateTime = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 100),
                        AuthorId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.AuthorId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 10),
                        Description = c.String(maxLength: 100),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TagEntityBlogEntities",
                c => new
                    {
                        TagEntity_Id = c.String(nullable: false, maxLength: 128),
                        BlogEntity_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.TagEntity_Id, t.BlogEntity_Id })
                .ForeignKey("dbo.Tag", t => t.TagEntity_Id, cascadeDelete: true)
                .ForeignKey("dbo.Blog", t => t.BlogEntity_Id, cascadeDelete: true)
                .Index(t => t.TagEntity_Id)
                .Index(t => t.BlogEntity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blog", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.TagEntityBlogEntities", "BlogEntity_Id", "dbo.Blog");
            DropForeignKey("dbo.TagEntityBlogEntities", "TagEntity_Id", "dbo.Tag");
            DropForeignKey("dbo.Tag", "AuthorId", "dbo.User");
            DropForeignKey("dbo.Comment", "BlogId", "dbo.Blog");
            DropForeignKey("dbo.Comment", "AuthorId", "dbo.User");
            DropForeignKey("dbo.Blog", "AuthorId", "dbo.User");
            DropIndex("dbo.TagEntityBlogEntities", new[] { "BlogEntity_Id" });
            DropIndex("dbo.TagEntityBlogEntities", new[] { "TagEntity_Id" });
            DropIndex("dbo.Tag", new[] { "AuthorId" });
            DropIndex("dbo.Comment", new[] { "AuthorId" });
            DropIndex("dbo.Comment", new[] { "BlogId" });
            DropIndex("dbo.Blog", new[] { "CategoryId" });
            DropIndex("dbo.Blog", new[] { "AuthorId" });
            DropTable("dbo.TagEntityBlogEntities");
            DropTable("dbo.Category");
            DropTable("dbo.Tag");
            DropTable("dbo.Comment");
            DropTable("dbo.User");
            DropTable("dbo.Blog");
        }
    }
}
