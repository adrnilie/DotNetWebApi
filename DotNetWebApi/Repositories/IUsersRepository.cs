using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetWebApi.Models;

namespace DotNetWebApi.Repositories
{
    public interface IUsersRepository
    {
        Task<IEnumerable<UsersModel>> GetUsers();
    }
}