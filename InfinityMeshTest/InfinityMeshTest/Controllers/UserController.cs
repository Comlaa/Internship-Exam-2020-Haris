using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.Repository;
using InfinityMeshTest.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace InfinityMeshTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserRepository _UserRepository;

        public UserController(IUserRepository userRepostiry)
        {
            _UserRepository = userRepostiry;
        }

        [HttpGet]
        public async Task<List<UserDto>> GetUsers()
        {
            var Collection = await _UserRepository.GetTopTen();

            return new List<UserDto>(Collection.Select(user => new UserDto(user)));
        }

        [HttpGet]
        public UserDto GetUserById(int userId)
        {
            return new UserDto(_UserRepository.GetUserById(userId));
        }

        [HttpPost]
        public async Task<UserDto> AddUser([FromBody] UserDto user)
        {
            if (!ModelState.IsValid)
            {
                Debug.WriteLine("Validation exception!");
            }

            var UserDomain = new User
            {
                Name = user.Name,
            };

            await _UserRepository.AddUser(UserDomain);

            return user;
        }

    }
}
