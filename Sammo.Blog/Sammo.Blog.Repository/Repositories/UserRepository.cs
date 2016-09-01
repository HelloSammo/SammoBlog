using Sammo.Blog.Common;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class UserRepository : DbContextService, IUserRepository
    {
        public async Task<bool> AddAsync(UserEntity user)
        {
            Requires.NotNull(user, nameof(user));
            var result = DbContext.Set<UserEntity>().Add(user);
            if(result != null)
            {
                await DbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Task<bool> DeleteAsync(UserEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UserEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetComfirmedUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetUnconfirmedUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEmailExistsAsync(string email)
        {
            Requires.NotNullOrEmpty(email, nameof(email));
            return DbContext.Set<UserEntity>().AnyAsync(u => u.Email == email);
        }

        public Task<bool> IsUserNameExistsAsync(string userName)
        {
            Requires.NotNullOrEmpty(userName, nameof(userName));
            return DbContext.Set<UserEntity>().AnyAsync(u => u.UserName == userName);
        }

        public Task<UserEntity> GetUserByUserNameOrEmailAsync(string userNameOrEmail)
        {
            Requires.NotNullOrEmpty(userNameOrEmail, nameof(userNameOrEmail));
            return DbContext.Set<UserEntity>().FirstOrDefaultAsync(u => u.UserName == userNameOrEmail || u.Email == userNameOrEmail);
        }

        public Task<UserEntity> GetUserByUserNameAsync(string userName)
        {
            Requires.NotNullOrEmpty(userName, nameof(userName));
            return DbContext.Set<UserEntity>().FirstOrDefaultAsync(u => u.UserName == userName);
        }
    }
}
