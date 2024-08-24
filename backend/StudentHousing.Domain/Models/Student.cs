namespace StudentHousing.Domain.Models;

public sealed class Student
{
    public required Guid Id { get; init; }

    public required string Username { get; init; }

    public required string FullName { get; init; }

    public required string Email { get; init; }

    public required DateOnly Birthdate { get; init; }

    public required Room Room { get; set; }

    public ICollection<HousingTask> HousingTasks { get; set; } = new List<HousingTask>();
}