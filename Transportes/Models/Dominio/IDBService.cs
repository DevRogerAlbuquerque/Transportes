using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace Transportes.Models.Dominio
{
    public interface IDbService
    {
        Task<int> ExecuteAsync(string query, object parameters);
    }


    public class DbService : IDbService
    {
        private readonly IConfiguration _configuration;

        public DbService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> ExecuteAsync(string query, object parameters)
        {
            await using var connection = GetSqlConnection();
            return await connection.ExecuteAsync(query, parameters).ConfigureAwait(false);
        }

        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("Transportes"));
        }
    }
}