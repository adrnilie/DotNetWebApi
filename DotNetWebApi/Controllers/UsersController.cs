using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using DotNetWebApi.Core;
using DotNetWebApi.Repositories;

namespace DotNetWebApi.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUsersRepository usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        [Route("api/users")]
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await this.usersRepository.GetUsers();
        }
    }
}
