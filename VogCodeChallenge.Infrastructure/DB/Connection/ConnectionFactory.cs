using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace VogCodeChallenge.Infrastructure.DB.Connection
{
    public class ConnectionFactory: IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Get(ConnectionNames connectionName)
        {
            return new SqlConnection(_configuration.GetConnectionString(connectionName.ToString()));
        }
    }
}
