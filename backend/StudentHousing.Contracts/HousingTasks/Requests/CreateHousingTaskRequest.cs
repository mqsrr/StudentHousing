namespace StudentHousing.Contracts.HousingTasks.Requests;

public sealed class CreateHousingTaskRequest
{
    public Guid Id { get; } = Guid.NewGuid();

    public required string Title { get; init; }

    public required string Description { get; init; }
}