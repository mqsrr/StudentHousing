using StudentHousing.Domain.Models;

namespace StudentHousing.Application.Repositories;

public interface IRoomRepository
{
    Task<IEnumerable<Room>> GetAllRoomsAsync();

    Task<IEnumerable<Room>> GetAvailableRoomsAsync();
    
    Task<Room?> GetRoomByIdAsync(Guid id);

    Task<bool> CreateRoomAsync(Room room);
    
    Task<bool> AssignStudentToTheRoomAsync(Guid roomId, Guid studentId);
}