using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DotNetWebApi.Core.DataAccess
{
    public class ConnectionRepository: IConnectionRepository
    {
        public string GetConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DotNetWebApiDb"].ConnectionString;

            if (this.TestConnection(new SqlConnection(connectionString)))
            {
                return connectionString;
            }
            else
            {
                return string.Empty;
            }
        }

        private bool TestConnection(SqlConnection connection)
        {
            var result = false;

            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    result = true;
                }
            }
            catch (Exception e)
            {
                result = false;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}