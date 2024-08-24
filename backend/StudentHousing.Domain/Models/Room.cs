namespace StudentHousing.Domain.Models;

public sealed class Room
{
    public required Guid RoomId { get; init; }

    public required int Floor { get; init; }

    public required int RoomNumber { get; init; }
}