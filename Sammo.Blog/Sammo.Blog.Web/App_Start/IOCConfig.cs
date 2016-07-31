using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.AspNet.Identity;
using Sammo.Blog.Core.Interfaces;
using Sammo.Blog.Core.Services;
using Sammo.Blog.Repository.Repositories;
using Sammo.Blog.Repository.Repositories.Interfaces;
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
            //注册Service
            builder.RegisterType<AccountService>().As<IAccountService>();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}