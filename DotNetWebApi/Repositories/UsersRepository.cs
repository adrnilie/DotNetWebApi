using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DotNetWebApi.Core.DataAccess;
using DotNetWebApi.Models;

namespace DotNetWebApi.Repositories
{
    public class UsersRepository: IUsersRepository
    {
        private readonly IConnectionRepository connectionRepository;

        public UsersRepository(IConnectionRepository connectionRepository)
        {
            this.connectionRepository = connectionRepository;
        }

        public async Task<IEnumerable<UsersModel>> GetUsers()
        {
            var connectionString = this.connectionRepository.GetConnectionString();

            using (var db = new SqlConnection(connectionString))
            {
                return await db.QueryAsync<UsersModel>(@"SELECT * FROM dbo.[Users]", null, null, null, CommandType.Text);
            }
        }
    }
}