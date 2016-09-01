using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.EntityFramework;
using Sammo.Blog.Repository.Repositories;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class AdminBaseController : Controller
    {
        private readonly IUserRepository _repository;

        //public AdminBaseController() { }
        public AdminBaseController(IUserRepository repository)
        {
            _repository = repository;
        }

        protected bool UserIsAuthenticated
        {
            get
            {
                return System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            }
        }
        

        protected string UserId
        {
            get
            {
                return UserIsAuthenticated ? User.Identity.GetUserId() : null;
            }
        }
        protected string UserName
        {
            get
            {
                return UserIsAuthenticated ? System.Web.HttpContext.Current.User.Identity.Name : null;
            }
        }

        protected UserEntity CurrentUser
        {
            get
            {
                return GetCurrentUser().Result;
            }
        }

        protected  Task<UserEntity> GetCurrentUser()
        {
            return   _repository.GetUserByUserNameAsync(UserName);
        }
        


        //protected override  JsonResult Json(object data,Encoding contentEncoding, string contentType= "application/json"
        //    , JsonRequestBehavior behavior = JsonRequestBehavior.AllowGet)
        //{
        //    return new JsonResult
        //    {
        //        Data = data,
        //        ContentEncoding = contentEncoding,
        //        ContentType = contentType,
        //        JsonRequestBehavior = behavior
        //    };
        //}


        protected new JsonResult Json(object data, string contentType = "application/json"
            , JsonRequestBehavior behavior = JsonRequestBehavior.AllowGet)
        {
            return new JsonResult
            {
                Data = data,
                ContentType = contentType,
                JsonRequestBehavior = behavior
            };
        }
    }
}