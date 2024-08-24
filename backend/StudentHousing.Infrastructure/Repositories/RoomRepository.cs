using StudentHousing.Application.Persistence;
using StudentHousing.Application.Repositories;
using StudentHousing.Domain.Models;
using StudentHousing.Infrastructure.Helpers;

namespace StudentHousing.Infrastructure.Repositories;

internal sealed class RoomRepository(ISqlDataAccess dataAccess) : IRoomRepository
{
    private readonly ISqlDataAccess _dataAccess = dataAccess;

    public Task<IEnumerable<Room>> GetAllRoomsAsync()
    {
        return _dataAccess.ExecuteQueryAsync<Room, dynamic>(StoredProcedures.Rooms.GetAll, new { });
    }

    public Task<IEnumerable<Room>> GetAvailableRoomsAsync()
    {
        return _dataAccess.ExecuteQueryAsync<Room, dynamic>(StoredProcedures.Rooms.GetAvailableRooms, new { });
    }

    public async Task<Room?> GetRoomByIdAsync(Guid id)
    {
        var result = await _dataAccess.ExecuteQueryAsync<Room, dynamic>(StoredProcedures.Rooms.GetById, new {Id = id});
        return result.FirstOrDefault();
    }

    public Task<bool> CreateRoomAsync(Room room)
    {
        return _dataAccess.ExecuteScalarAsync(StoredProcedures.Rooms.Create, new {Id = room.RoomId, room.Floor, room.RoomNumber});
    }

    public Task<bool> AssignStudentToTheRoomAsync(Guid roomId, Guid studentId)
    {
        return _dataAccess.ExecuteScalarAsync(StoredProcedures.Rooms.AssignStudent,
            new {StudentId = studentId, RoomId = roomId});
    }
}