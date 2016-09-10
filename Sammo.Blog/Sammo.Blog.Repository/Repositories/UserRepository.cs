using Sammo.Blog.Common;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Repositories
{
    public class UserRepository : DbContextService<EntityBase>, IUserRepository
    {
        public async Task<bool> AddAsync(UserEntity user)
        {
            var result = DbContext.Set<UserEntity>().Add(user);
            if (result == null)
                return false;

            await DbContext.SaveChangesAsync();
            return true;
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

        public  Task<UserEntity> GetUserByIdAsync(string id)
        {
            return DbContext.Set<UserEntity>().FirstAsync(u => u.Id == id);
        }

        public Task<bool> IsEmailExistsAsync(string email)
        {
            return DbContext.Set<UserEntity>().AnyAsync(u => u.Email == email);
        }

        public Task<bool> IsUserNameExistsAsync(string userName)
        {
            return DbContext.Set<UserEntity>().AnyAsync(u => u.UserName == userName);
        }

        public Task<UserEntity> GetUserByUserNameOrEmailAsync(string userNameOrEmail)
        {
            return DbContext.Set<UserEntity>().FirstOrDefaultAsync(u => u.UserName == userNameOrEmail || u.Email == userNameOrEmail);
        }

        public Task<UserEntity> GetUserByUserNameAsync(string userName)
        {
            return DbContext.Set<UserEntity>().AsNoTracking().FirstOrDefaultAsync(u => u.UserName == userName);
        }
    }
}
