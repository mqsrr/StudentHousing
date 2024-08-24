using System.Data;
using Dapper;
using StudentHousing.Domain.Models;

namespace StudentHousing.Infrastructure.TypeHandlers;

public class DateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly> 
{
    public override DateOnly Parse(object value) => DateOnly.FromDateTime((DateTime)value);

    public override void SetValue(IDbDataParameter parameter, DateOnly value)
    {
        parameter.DbType = DbType.Date;
        parameter.Value = value.ToString();
    }
}

public class TimeOnlyTypeHandler : SqlMapper.TypeHandler<TimeOnly> // Dapper handler for TimeOnly
{
    public override TimeOnly Parse(object value)
    {
        return value switch
        {
            DateTime time => TimeOnly.FromDateTime(time),
            TimeSpan span => TimeOnly.FromTimeSpan(span),
            _ => default
        };
    }

    public override void SetValue(IDbDataParameter parameter, TimeOnly value)
    {
        parameter.DbType = DbType.Time;
        parameter.Value = value;
    }
}