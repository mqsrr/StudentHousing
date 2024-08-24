using StudentHousing.Domain.Models;

namespace StudentHousing.Contracts.Auth.Requests;

public sealed class RegisterRequest
{
    public Guid Id { get; } = Guid.NewGuid();

    public required string Username { get; init; }

    public required string FullName { get; init; }

    public required string Password { get; init; }

    public required string Email { get; init; }

    public required DateOnly Birthdate { get; init; }

    public required Room Room { get; init; }

    public Role Role { get; init; } = Role.Student;
}