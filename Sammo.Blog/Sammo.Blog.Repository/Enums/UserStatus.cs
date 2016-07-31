using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Enums
{
    public enum UserInvokeResult
    {
        Success,
        UserNameExists,
        EmailExists
    }

    public enum UserLoginInvokeResult
    {
        Success,
        UserOrEmailNotFound,
        PasswordIncorrect
    }
}
