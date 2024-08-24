using StudentHousing.Contracts.HousingTasks.Responses;
using StudentHousingApp.Models;

namespace StudentHousingApp.Mappers;

internal static class HousingTaskMapper
{
    public static HousingTask ToTask(this HousingTaskResponse response)
    {
        return new HousingTask
        {
            Id = response.Id,
            Title = response.Title,
            Description = response.Description,
            State = (HousingTaskState)response.State,
            DueDate = response.DueDate
        };
    }
}
