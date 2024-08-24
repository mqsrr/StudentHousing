using StudentHousing.Domain.Models;

namespace StudentHousing.Application.Repositories;

public interface IStudentRepository
{
    Task<Student?> GetStudentByIdAsync(Guid id);
    
    Task<Student?> GetStudentByUsernameAsync(string username);
    
    Task<bool> CreateStudentAsync(Student student);
}