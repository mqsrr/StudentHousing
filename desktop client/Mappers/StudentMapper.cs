using StudentHousing.Contracts.Students.Responses;
using StudentHousingApp.Models;

namespace StudentHousingApp.Mappers;

internal static class StudentMapper
{
    public static Student ToStudent(this StudentResponse response)
    {
        var student = new Student
        {
            Id = response.Id,
            Username = response.Username,
            Email = response.Email,
            FullName = response.FullName,
            Birthdate = response.Birthdate,
            Room = response.Room.ToRoom(),
            HousingTasks = response.HousingTasks.Select(task => task.ToTask()).ToList(),
            JoinedPartyIds = response.JoinedParties.ToList()
        };
        student.Room.Student = student;

        return student;
    }
}
