namespace StudentHousing.Domain.Models;

public sealed class IdentityResponse
{
    public required Role Role { get; init; }

    public required string Token { get; init; }
}