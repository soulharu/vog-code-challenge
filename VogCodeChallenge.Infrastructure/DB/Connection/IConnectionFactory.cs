using System.Data;

namespace VogCodeChallenge.Infrastructure.DB.Connection
{
    public interface IConnectionFactory
    {
        IDbConnection Get(ConnectionNames connectionName);
    }
}
