using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfinityMeshTest.Dal.Repository
{
    public interface IUserRepository
    {
        Task<UserDto> AddUser(User user, CancellationToken cancellationToken = default);
        bool DeleteUser(int userId);
        Task<List<User>> GetTopFive (CancellationToken cancellationToken = default);
        User GetUserById(int userId);
    }
}
