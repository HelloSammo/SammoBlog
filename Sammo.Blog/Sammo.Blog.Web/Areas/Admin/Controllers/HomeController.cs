using Sammo.Blog.Repository.Repositories.Interfaces;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [Authorize]
    public class HomeController : AdminBaseController
    {
        private readonly IUserRepository _repository;
        public HomeController(IUserRepository repository):base(repository)
        {
            _repository = repository;
        }
        // 后台登录后跳转此页面，此页面用于布局后台博客系统的信息统计
        public ActionResult Index()
        {
            return View();
        }
    }
}