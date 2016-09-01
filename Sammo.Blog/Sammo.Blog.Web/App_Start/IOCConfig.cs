using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.AspNet.Identity;
using Sammo.Blog.Core.Interfaces;
using Sammo.Blog.Core.Services;
using Sammo.Blog.Repository.Repositories;
using Sammo.Blog.Repository.Repositories.Interfaces;
using Sammo.Blog.Web.Areas.Admin.Controllers;
using System.Web.Mvc;

namespace Sammo.Blog.Web.App_Start
{
    public class IOCConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //builder.RegisterType<ApplicationUserManager>().As<UserManager<Models.ApplicationUser>>();


            //注册Repository
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CommentRepository>().As<ICommentRepository>();
            builder.RegisterType<TagRepository>().As<ITagRepository>();
            builder.RegisterType<BlogRepository>().As<IBlogRepository>();
            //builder.RegisterType<BlogTagMapRepository>().As<IBlogTagMapRepository>();

            //注册Service
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<BlogService>().As<IBlogService>();
            builder.RegisterType<TagService>().As<ITagService>();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}