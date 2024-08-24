namespace StudentHousingApp.Models;

public sealed class Room
{
    public required Guid Id { get; init; }

    public required int Floor { get; init; }

    public required int RoomNumber { get; init; }

    public Student? Student { get; set; }

    public override string ToString()
    {
        return Student is null ? $"Floor: {Floor}, Room Number: {RoomNumber}" : Student.ToString()!;
    }
}