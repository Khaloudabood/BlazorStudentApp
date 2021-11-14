using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace EFDataAccessLibrary
{
    public class SqliteDataAccess : ISqliteDataAccess
    {
        private readonly IConfiguration _config;

        public String ConnectionStringName { get; set; } = "Defult";

        public SqliteDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoudData<T, U>(String sqlite, U parameters)
        {
            String connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqliteConnection(connectionString);
            var data = await connection.QueryAsync<T>(sqlite, parameters);

            return data.ToList();
        }

        public async Task SaveData<T>(String Sqlite, T parameters)

        {
            String connectionString = _config.GetConnectionString(ConnectionStringName);

            using IDbConnection connection = new SqliteConnection(connectionString);
            await connection.ExecuteAsync(Sqlite, parameters);

        }
    }
}
