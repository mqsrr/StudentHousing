using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using StudentHousing.Application.Persistence;
using StudentHousing.Infrastructure.TypeHandlers;

namespace StudentHousing.Infrastructure.Persistence;

internal sealed class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _configuration;

    public SqlDataAccess(IConfiguration configuration)
    {
        _configuration = configuration;
        SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());
        SqlMapper.AddTypeHandler(new TimeOnlyTypeHandler());
    }

    public async Task<IEnumerable<TEntity>> ExecuteQueryAsync<TEntity, TParam>(string storedProcedure, TParam parameters)
    {
        await using var connection = new SqlConnection(_configuration["StudentHousingDB:ConnectionString"]);
        var result = await connection.QueryAsync<TEntity>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

        return result;
    }

    public async Task<IEnumerable<TReturn>> ExecuteQueryAsync<TFirst, TSecond, TThird, TReturn, TParam>(string storedProcedure,
        Func<TFirst, TSecond, TThird, TReturn> map, string splitOn,TParam parameters)
    {
        await using var connection = new SqlConnection(_configuration["StudentHousingDB:ConnectionString"]);
        var result = await connection.QueryAsync(storedProcedure, map, parameters, splitOn: splitOn, commandType: CommandType.StoredProcedure);

        return result;
    }

    public async Task<bool> ExecuteScalarAsync<TEntity>(string storedProcedure, TEntity parameters)
    {
        await using var connection = new SqlConnection(_configuration["StudentHousingDb:ConnectionString"]);
        int affectedRows = await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

        return affectedRows > 0;
    }
}