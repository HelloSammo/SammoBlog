using Sammo.Blog.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sammo.Blog.Web.Areas.Admin.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "用户名")]
        [RegularExpression(BlogConstants.Regex.AllowedUserNameRegex, ErrorMessage = BlogConstants.Error.UserNameError)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "邮箱地址")]
        [EmailAddress(ErrorMessage = BlogConstants.Error.EmailError)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "密码")]
        [StringLength(20, ErrorMessage = BlogConstants.Error.PasswordError, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }
    }
}