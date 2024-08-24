namespace StudentHousing.Contracts.Rooms;

public sealed class CreateRoomRequest
{
    public Guid Id { get; } = Guid.NewGuid();

    public required int Floor { get; init; }

    public required int RoomNumber { get; init; }
}