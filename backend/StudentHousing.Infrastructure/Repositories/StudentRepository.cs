using StudentHousing.Application.Persistence;
using StudentHousing.Application.Repositories;
using StudentHousing.Domain.Models;
using StudentHousing.Infrastructure.Helpers;

namespace StudentHousing.Infrastructure.Repositories;

internal sealed class StudentRepository(ISqlDataAccess dataAccess) : IStudentRepository
{
    private readonly ISqlDataAccess _dataAccess = dataAccess;

    public async Task<Student?> GetStudentByIdAsync(Guid id)
    {
        var result = await _dataAccess.ExecuteQueryAsync<Student, Room, HousingTask, Student, dynamic>(
            StoredProcedures.Students.GetById,
            (student, room, housingTask) =>
            {
                student.Room = room;
                student.HousingTasks.Add(housingTask);
                return student;
            }, "RoomId, HousingTaskId", new {Id = id});

        result = result.GroupBy(student => student.Id)
            .Select(g =>
            {
                var groupedStudent = g.First();
                groupedStudent.HousingTasks = g.Select(housingTask => housingTask.HousingTasks.Single()).ToList();
                return groupedStudent;
            });

        return result.FirstOrDefault();
    }

    public async Task<Student?> GetStudentByUsernameAsync(string username)
    {
        var result = await _dataAccess.ExecuteQueryAsync<Student, Room, HousingTask, Student, dynamic>(
            StoredProcedures.Students.GetByUsername,
            (student, room, housingTask) =>
            {
                student.Room = room;
                student.HousingTasks.Add(housingTask);
                return student;
            }, "RoomId, HousingTaskId", new {Username = username});

        result = result.GroupBy(student => student.Id)
            .Select(g =>
            {
                var groupedStudent = g.First();
                groupedStudent.HousingTasks = g.Select(housingTask => housingTask.HousingTasks.Single()).ToList();
                return groupedStudent;
            });

        return result.FirstOrDefault();
    }

    public async Task<bool> CreateStudentAsync(Student student)
    {
        bool isCreated = await _dataAccess.ExecuteScalarAsync(StoredProcedures.Students.Create,
            new
            {
                student.Id, 
                student.Username, 
                student.FullName, 
                student.Birthdate,
                student.Email,
                student.Room.RoomId
            });

        return isCreated;
    }
}