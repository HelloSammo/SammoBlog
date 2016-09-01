using Sammo.Blog.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories.Interfaces
{
    public interface IUserRepository 
    {
        Task<bool> AddAsync(UserEntity user);
        Task<UserEntity> GetUserByIdAsync(string id);

        Task<IEnumerable<UserEntity>> GetComfirmedUsersAsync();

        Task<IEnumerable<UserEntity>> GetUnconfirmedUsersAsync();

        Task<bool> IsEmailExistsAsync(string email);

        Task<bool> IsUserNameExistsAsync(string userName);

        Task<UserEntity> GetUserByUserNameOrEmailAsync(string userNameOrEmail);

        Task<UserEntity> GetUserByUserNameAsync(string userName);
    }
}
