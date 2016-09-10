using Sammo.Blog.Common;
using Sammo.Blog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogService _blogService;
        public HomeController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<ActionResult> Index(int? p)
        {
            //var pageIndex = p ?? 1;
            //var result = await _blogService.GetAsync(pageIndex, BlogConstants.Setting.BlogsPerPage);
            return View();
        }

        public async Task<JsonResult> GetBlogs(int? p)
        {
            var pageIndex = p ?? 1;
            var result = await _blogService.GetAsync(pageIndex, BlogConstants.Setting.BlogsPerPage);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View(ViewBag.Temp);
        }
    }
}