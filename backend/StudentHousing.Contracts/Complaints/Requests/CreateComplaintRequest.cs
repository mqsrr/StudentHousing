namespace StudentHousing.Contracts.Complaints.Requests;

public sealed class CreateComplaintRequest
{
    public Guid Id { get; } = Guid.NewGuid();
    
    public required string Title { get; init; }
    
    public required string Description { get; init; }
}