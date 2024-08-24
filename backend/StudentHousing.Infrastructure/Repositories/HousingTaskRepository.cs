using StudentHousing.Application.Persistence;
using StudentHousing.Application.Repositories;
using StudentHousing.Domain.Models;
using StudentHousing.Infrastructure.Helpers;

namespace StudentHousing.Infrastructure.Repositories;

internal sealed class HousingTaskRepository(ISqlDataAccess dataAccess) : IHousingTaskRepository
{
    private readonly ISqlDataAccess _dataAccess = dataAccess;

    public Task<bool> CreateHousingTaskAsync(HousingTask housingTask, Guid studentId)
    {
        return _dataAccess.ExecuteScalarAsync(StoredProcedures.HousingTasks.Create,
            new {StudentId = studentId, Id = housingTask.HousingTaskId, housingTask.State, housingTask.Description, housingTask.Title});
    }

    public Task<bool> UpdateTaskStateAsync(Guid id, HousingTaskState taskState)
    {
        return _dataAccess.ExecuteScalarAsync(StoredProcedures.HousingTasks.UpdateState,
            new {Id = id, State = taskState});
    }

    public Task<bool> DeleteHousingTaskByIdAsync(Guid id)
    {
        return _dataAccess.ExecuteScalarAsync(StoredProcedures.HousingTasks.DeleteById, new {Id = id});
    }

}