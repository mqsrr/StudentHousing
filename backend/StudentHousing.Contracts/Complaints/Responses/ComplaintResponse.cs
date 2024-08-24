namespace StudentHousing.Contracts.Complaints.Responses;

public sealed class ComplaintResponse
{
    public required Guid Id { get; init; }

    public required string Title { get; init; }

    public required string Description { get; init; }

    public required DateTime CreatedAt { get; init; }
}