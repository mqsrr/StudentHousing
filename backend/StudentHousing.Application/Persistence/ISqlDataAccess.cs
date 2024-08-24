namespace StudentHousing.Application.Persistence;

public interface ISqlDataAccess
{
    Task<IEnumerable<TEntity>> ExecuteQueryAsync<TEntity, TParam>(string storedProcedure, TParam parameters);

    Task<IEnumerable<TReturn>> ExecuteQueryAsync<TFirst, TSecond, TThird, TReturn, TParam>(string storedProcedure,
        Func<TFirst, TSecond, TThird, TReturn> map, string splitOn, TParam parameters);

    Task<bool> ExecuteScalarAsync<TEntity>(string storedProcedure, TEntity parameters);
}