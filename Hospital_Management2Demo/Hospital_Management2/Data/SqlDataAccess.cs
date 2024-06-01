using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital_Management2.Data
{
	public class SqlDataAccess : ISqlDataAccess
	{
		private readonly IConfiguration _configuration;
		private readonly ILogger<SqlDataAccess> _logger;

		public SqlDataAccess(IConfiguration configuration, ILogger<SqlDataAccess> logger)
		{
			_configuration = configuration;
			_logger = logger;
		}

		public async Task<IEnumerable<T>> GetDataAsync<T, P>(
			string storedProcedure, P parameters, string connection = "DefaultConnection")
		{
			try
			{
				var connectionString = _configuration.GetConnectionString(connection);

				if (string.IsNullOrEmpty(connectionString))
				{
					throw new InvalidOperationException("The connection string is not configured.");
				}

				using IDbConnection dbConnection = new SqlConnection(connectionString);

				return await dbConnection.QueryAsync<T>(
					storedProcedure,
					parameters,
					commandType: CommandType.StoredProcedure);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error occurred while executing GetDataAsync");
				throw;
			}
		}

		public async Task SaveDataAsync<T>(
			string storedProcedure,
			T parameters,
			string connection = "DefaultConnection")
		{
			try
			{
				var connectionString = _configuration.GetConnectionString(connection);

				if (string.IsNullOrEmpty(connectionString))
				{
					throw new InvalidOperationException("The connection string is not configured.");
				}

				using IDbConnection dbConnection = new SqlConnection(connectionString);

				await dbConnection.ExecuteAsync(
					storedProcedure,
					parameters,
					commandType: CommandType.StoredProcedure);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error occurred while executing SaveDataAsync");
				throw;
			}
		}
	}
}
