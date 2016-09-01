using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Common
{
    public sealed class BlogConstants
    {
        public class Validation
        {
            public const int GuidStringLength = 36;
            public const int BlogTitleLength = 30;
            public const int CategoryNameLength = 10;
            public const int CommentLength = 300;
            public const int TagNameLength = 10;
            public const int TagDescriptionLength = 100;
            public const int UserNameLength = 15;
            public const int EmailLength = 50;
            public const int PasswordLength = 128;
            public const int CategoryDescriptionLength = 100;

            
        }

        public class Setting
        {
            public const int BlogsPerPage = 8;
        }

        public class Error
        {
            public const string PasswordError = "密码必须为6~20个字符，字母+数字组合";
            public const string EmailError = "邮箱地址不正确";
            public const string UserNameError = "用户名必须为4-30个字符，支持英文，数字，下划线";
            public const string EmailExists = "此邮箱已存在";
            public const string UserNameExists = "此用户名已存在";
            public const string UserNotFound = "该用户不存在";
            public const string PasswordIncorrect = "密码不正确";
            public const string CategoryExists = "此分类已存在";
            public const string InvalidCategory = "此分类名无效";
        }

        public class Regex
        {
            public const string AllowedUserNameRegex = "^[A-Za-z0-9_]{4,30}$";


        }

        public class Utils
        {
            public const int SaltSize = 24;
            public const int CookieSaveDays = 14;
        }
    }
}
