namespace StudentHousing.Domain.Models;

public sealed class HousingTask
{
    public required Guid HousingTaskId { get; init; }

    public required string Title { get; init; }

    public required string Description { get; init; }

    public required HousingTaskState State { get; init; }
}