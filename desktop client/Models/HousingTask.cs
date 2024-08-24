namespace StudentHousingApp.Models;

public sealed class HousingTask
{
    public required Guid Id { get; init; }

    public required string Title { get; init; }

    public required string Description { get; init; }

    public required HousingTaskState State { get; set; }

    public required DateTime DueDate { get; init; }

    public override string ToString()
    {
        return $"Title: {Title}. Due Date: {DueDate:d}";
    }
}