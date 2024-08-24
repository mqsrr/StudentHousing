namespace StudentHousingApp.Models;

public sealed class Message
{
    public required Guid Id { get; init; }

    public required Guid PartyId { get; init; }

    public required Guid StudentId { get; init; }

    public string? Username { get; set; } = null!;

    public required string Content { get; init; }

    public required DateTime SentAt { get; init; }

    public override string ToString()
    {

        return $"{Username}: {Content} - {SentAt:t}";
    }
}
