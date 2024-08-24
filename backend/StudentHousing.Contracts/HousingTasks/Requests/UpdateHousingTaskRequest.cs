using StudentHousing.Domain.Models;

namespace StudentHousing.Contracts.HousingTasks.Requests;

public sealed class UpdateHousingTaskRequest
{
    public required HousingTaskState State { get; init; }
}