using StudentHousing.Domain.Models;

namespace StudentHousing.Contracts.Auth.Requests;

public sealed class RegisterAdminRequest
{
    public Guid Id { get; } = Guid.NewGuid();

    public required string Username { get; init; }

    public required string Password { get; init; }

    public required string Email { get; init; }

    public required DateOnly Birthdate { get; init; }
    
    public Role Role { get; } = Role.Admin;
}