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
                        CreationTime = c.DateTime(nullable: false),
                        VisitedAmount = c.Int(nullable: false),
                        IsTop = c.Boolean(nullable: false),
                        UserId = c.String(maxLength: 36),
                        CategoryId = c.String(maxLength: 128),
                        UserEntity_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .ForeignKey("dbo.User", t => t.UserEntity_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.UserEntity_Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 10),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationTime = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 300),
                        BlogId = c.String(maxLength: 128),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blog", t => t.BlogId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.BlogId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 128),
                        Role = c.Byte(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        AvatarId = c.String(maxLength: 36),
                        IsConfirmed = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 10),
                        CreationTime = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 100),
                        UserId = c.String(maxLength: 128),
                        BlogId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blog", t => t.BlogId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tag", "UserId", "dbo.User");
            DropForeignKey("dbo.Tag", "BlogId", "dbo.Blog");
            DropForeignKey("dbo.Comment", "UserId", "dbo.User");
            DropForeignKey("dbo.Blog", "UserEntity_Id", "dbo.User");
            DropForeignKey("dbo.Comment", "BlogId", "dbo.Blog");
            DropForeignKey("dbo.Blog", "CategoryId", "dbo.Category");
            DropIndex("dbo.Tag", new[] { "BlogId" });
            DropIndex("dbo.Tag", new[] { "UserId" });
            DropIndex("dbo.Comment", new[] { "UserId" });
            DropIndex("dbo.Comment", new[] { "BlogId" });
            DropIndex("dbo.Blog", new[] { "UserEntity_Id" });
            DropIndex("dbo.Blog", new[] { "CategoryId" });
            DropTable("dbo.Tag");
            DropTable("dbo.User");
            DropTable("dbo.Comment");
            DropTable("dbo.Category");
            DropTable("dbo.Blog");
        }
    }
}
