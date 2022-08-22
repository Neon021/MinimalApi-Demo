using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private IConfiguration _config;

        public SqlDataAccess(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<IEnumerable<U>> LoadData<U, T>(string storedProcedures, T parametres, string connectionID = "Default")
        {
            using IDbConnection dbconnection = new SqlConnection(_config.GetConnectionString(connectionID));

            return await dbconnection.QueryAsync<U>(storedProcedures, parametres, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string storedProcedures, T parametres, string connectionID = "Default")
        {
            using IDbConnection dbconnection = new SqlConnection(_config.GetConnectionString(connectionID));

            await dbconnection.ExecuteAsync(storedProcedures, parametres, commandType: CommandType.StoredProcedure);
        }
    }
}
