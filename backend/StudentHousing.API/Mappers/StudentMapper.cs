using StudentHousing.Contracts.Students.Responses;
using StudentHousing.Domain.Models;

namespace StudentHousing.API.Mappers;

internal static class StudentMapper
{
    internal static StudentResponse ToResponse(this Student student)
    {
        return new StudentResponse
        {
            Id = student.Id,
            Username = student.Username,
            FullName = student.FullName,
            Email = student.Email,
            Birthdate = student.Birthdate,
            Room = student.Room.ToResponse(),
            HousingTasks = student.HousingTasks.Any(task => task is null) ? [] : student.HousingTasks.Select(task => task.ToResponse()) 
        };
    }
}