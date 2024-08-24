namespace StudentHousingApp.Models;

public sealed class Complaint
{
    public required Guid Id { get; init; }

    public required string Title { get; init; }

    public required string Description { get; init; }

    public required DateTime CreatedAt { get; init; }

    public required ComplaintState State { get; set; }
}