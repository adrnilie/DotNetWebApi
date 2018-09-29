using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using DotNetWebApi.Models;
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
        public async Task<IEnumerable<UsersModel>> GetAllUsers()
        {
            return await this.usersRepository.GetUsers();
        }
    }
}
