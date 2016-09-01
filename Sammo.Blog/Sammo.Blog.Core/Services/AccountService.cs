using Sammo.Blog.Common;
using Sammo.Blog.Core.Interfaces;
using Sammo.Blog.Repository;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Enums;
using Sammo.Blog.Repository.Repositories;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Core.Services
{
    public class AccountService: IAccountService
    {
        private readonly IUserRepository _repository ;
        public AccountService(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<UserEntity> GetUserAsync(string name)
        {
            Requires.NotNull(name, nameof(name));
            return _repository.GetUserByUserNameAsync(name);
        }

        public Task<UserInvokeResult> LoginAsync(string userName,string password)
        {
            Requires.NotNull(userName, nameof(userName));
            Requires.NotNull(password, nameof(password));
            return null;
        }

        public async Task<UserInvokeResult> RegisterAsync(UserEntity user)
        {
            Requires.NotNull(user, nameof(user));
            
            if (await _repository.IsUserNameExistsAsync(user.UserName))
            {
                return UserInvokeResult.UserNameExists;
            }
            else if (await _repository.IsEmailExistsAsync(user.Email))
            {
                return UserInvokeResult.EmailExists;
            }

            var salt = Utils.CreateSalt(BlogConstants.Utils.SaltSize);
            var password = Utils.GenerateSaltedHash(user.Password, salt);
            user.PasswordSalt = salt;
            user.Password = password;
            await _repository.AddAsync(user);
            return UserInvokeResult.Success;
        }

        public async Task<UserLoginInvokeResult> ValidateUserAsync(string userNameOrEmail, string password)
        {
            Requires.NotNull(userNameOrEmail, nameof(userNameOrEmail));
            Requires.NotNull(password, nameof(password));
            var user = await _repository.GetUserByUserNameOrEmailAsync(userNameOrEmail);
            if(user == null)
                return UserLoginInvokeResult.UserOrEmailNotFound;

            var salt = user.PasswordSalt;
            password = Utils.GenerateSaltedHash(password, salt);
            if (password != user.Password)
                return UserLoginInvokeResult.PasswordIncorrect;

            return UserLoginInvokeResult.Success;
        }
    }
}
