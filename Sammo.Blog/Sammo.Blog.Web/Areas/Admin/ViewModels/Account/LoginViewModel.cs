using Sammo.Blog.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sammo.Blog.Web.Areas.Admin.ViewModels.Account
{
    public class LoginViewModel
    {
        //[Required(ErrorMessage = "{0}不能为空")]
        //[Display(Name = "用户名")]
        //[RegularExpression(BlogConstants.Regex.AllowedUserNameRegex, ErrorMessage = BlogConstants.Error.UserNameError)]
        //public string UserName { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "用户名或邮箱")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "密码")]
        [StringLength(20, ErrorMessage = BlogConstants.Error.PasswordError, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "记住我？")]
        public bool RememberMe { get; set; } = true;
    }
}