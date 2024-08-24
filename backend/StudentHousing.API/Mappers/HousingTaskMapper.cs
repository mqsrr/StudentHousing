using StudentHousing.Contracts.HousingTasks.Requests;
using StudentHousing.Contracts.HousingTasks.Responses;
using StudentHousing.Domain.Models;

namespace StudentHousing.API.Mappers;

internal static class HousingTaskMapper
{
    internal static HousingTask ToHousingTask(this CreateHousingTaskRequest request)
    {
        return new HousingTask
        {
            HousingTaskId = request.Id,
            Title = request.Title,
            Description = request.Description,
            State = HousingTaskState.TODO
        };
    }
    
    internal static HousingTaskResponse ToResponse(this HousingTask housingTask)
    {
        return new HousingTaskResponse
        {
            Id = housingTask.HousingTaskId,
            Title = housingTask.Title,
            Description = housingTask.Description,
            State = housingTask.State
        };
    }
}