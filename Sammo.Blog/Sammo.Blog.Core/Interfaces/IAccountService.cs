using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Core.Interfaces
{
    public interface IAccountService
    {
        Task<UserInvokeResult> RegisterAsync(UserEntity user);

        Task<UserInvokeResult> LoginAsync(string userName, string password);

        Task<UserLoginInvokeResult> ValidateUserAsync(string userNameOrEmail, string password);

        
    }
}
