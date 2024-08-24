namespace StudentHousing.Contracts.Rooms.Responses;

public sealed class RoomResponse
{
    public required Guid Id { get; init; }

    public required int Floor { get; init; }

    public required int RoomNumber { get; init; }
}