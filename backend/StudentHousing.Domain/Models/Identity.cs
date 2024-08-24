using System.Security.Principal;

namespace StudentHousing.Domain.Models;

public sealed class Identity
{
    public required Guid Id { get; init; }

    public required string Username { get; init; }

    public required string Email { get; init; }

    public required string Password { get; set; }

    public required Role Role { get; init; }

    public required DateOnly Birthdate { get; init; }
}