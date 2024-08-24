namespace StudentHousingApp.Models;

public sealed class Party
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required string Description { get; init; }

    public required DateTime StartDate { get; init; }

    public required ICollection<Message> Messages { get; set; }

    public required ICollection<Student> Members { get; init; }

    public override string ToString()
    {
        return $"{Name} - {StartDate:g}";
    }
}
