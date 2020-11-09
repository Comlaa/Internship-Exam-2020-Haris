using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfinityMeshTest.Dal.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMDbContext Context;
        public UserRepository(IMDbContext context)
        {
            Context = context;
        }
        public async Task<UserDto> AddUser(User user, CancellationToken cancellationToken = default)
        {
            Context.Users.Add(user);
            await Context.SaveChangesAsync(cancellationToken);

            return new UserDto(user);
        }

        public bool DeleteUser(int userId)
        {
            var user = Context.Users.Find(userId);
            Context.Users.Remove(user);

            return true;
        }

        public async Task<List<User>> GetSearchedList(string searchString, CancellationToken cancellationToken = default)
        {
            int Number = 5;

            return await Context.Users.Take(Number).Where(p => p.Name.ToLower().Contains(searchString.ToLower()) ||
            p.Email.ToLower().Contains(searchString.ToLower())).ToListAsync(cancellationToken);
        }

        public async Task<List<User>> GetTopFive(CancellationToken cancellationToken = default)
        {
            int Number = 5;

            return await Context.Users.Take(Number).OrderBy(x => x.Name).ToListAsync(cancellationToken);
        }

        public User GetUserById(int userId)
        {
            return Context.Users.Find(userId);
        }
    }
}
