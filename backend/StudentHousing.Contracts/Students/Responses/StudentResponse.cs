using StudentHousing.Contracts.HousingTasks.Responses;
using StudentHousing.Contracts.Rooms.Responses;

namespace StudentHousing.Contracts.Students.Responses;

public sealed class StudentResponse
{
    public required Guid Id { get; init; }

    public required string Username { get; init; }

    public required string FullName { get; init; }

    public required string Email { get; init; }

    public required DateOnly Birthdate { get; init; }

    public required RoomResponse Room { get; init; }

    public required IEnumerable<HousingTaskResponse> HousingTasks { get; init; }
}