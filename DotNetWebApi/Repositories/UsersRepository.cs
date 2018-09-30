using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using DotNetWebApi.Core;

namespace DotNetWebApi.Repositories
{
    public class UsersRepository: IUsersRepository
    {
        public async Task<IEnumerable<User>> GetUsers()
        {
            using (var context = new WebApiDbEntities())
            {
                return await context.Users.ToListAsync();
            }
        }
    }
}