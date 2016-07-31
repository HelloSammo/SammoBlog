using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Areas.Admin.Controllers
{
    public class BlogController : AdminBaseController
    {
        // GET: Admin/Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}