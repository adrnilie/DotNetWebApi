using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetWebApi.Core;

namespace DotNetWebApi.Repositories
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetUsers();
    }
}