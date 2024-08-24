using StudentHousing.Domain.Models;

namespace StudentHousing.Contracts.HousingTasks.Responses;

public sealed class HousingTaskResponse
{
    public required Guid Id { get; init; }

    public required string Title { get; init; }

    public required string Description { get; init; }

    public required HousingTaskState State { get; init; }   
}