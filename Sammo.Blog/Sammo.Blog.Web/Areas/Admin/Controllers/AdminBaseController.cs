using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Sammo.Blog.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Areas.Admin.Controllers
{
    public class AdminBaseController: Controller
    {

        protected bool UserIsAuthenticated
        {
            get
            {
                return System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            }
        }

        protected string UserName
        {
            get
            {
                return UserIsAuthenticated ? System.Web.HttpContext.Current.User.Identity.Name : null;
            }
        }
















        //private IOwinContext m_OwinContext;
        //public IOwinContext OwinContext
        //{
        //    get
        //    {
        //        if (this.m_OwinContext == null)
        //        {
        //            this.m_OwinContext = base.Request.GetOwinContext();
        //        }
        //        return this.m_OwinContext;
        //    }
        //    set
        //    {
        //        Requires.NotNull<IOwinContext>(value, "value");
        //        this.m_OwinContext = value;
        //    }
        //}

        //public TUser User
        //{
        //    get
        //    {
        //        if (this.m_User == null)
        //        {
        //            this.m_User = base.OwinContext.GetAppUser<TUser>();
        //        }
        //        return this.m_User;
        //    }
        //    set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException("value");
        //        }
        //        base.OwinContext.SetAppUser<TUser>(value);
        //        this.m_User = value;
        //    }
        //}


    }
}