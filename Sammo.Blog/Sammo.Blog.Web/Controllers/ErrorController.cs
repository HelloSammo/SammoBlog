using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("~/Error/HttpNotFound")]
        public ActionResult HttpNotFoundError()
        {
            return View("HttpNotFound");
        }

        public ActionResult ServerError()
        {
            return View("ServerError");
        }
    }
}