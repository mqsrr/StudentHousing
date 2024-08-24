namespace StudentHousingApp.Models;

public sealed class Student
{
    public required Guid Id { get; init; }

    public required string Username { get; init; }

    public required string FullName { get; init; }

    public required string Email { get; init; }

    public required DateOnly Birthdate { get; init; }

    public required Room Room { get; init; }

    public required ICollection<HousingTask> HousingTasks { get; init; }

    public required ICollection<Guid> JoinedPartyIds { get; init; }


    public override string ToString()
    {
        int amountOfAssignedTask = HousingTasks.Count();
        string assignTasks = amountOfAssignedTask > 0 ? $"Assigned Tasks: {amountOfAssignedTask}" : "No assigned tasks";

        return $"Floor: {Room.Floor}, Room Number: {Room.RoomNumber} - Student: {FullName}, {assignTasks}";
    }

}