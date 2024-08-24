using StudentHousing.Contracts.Rooms;
using StudentHousing.Contracts.Rooms.Responses;
using StudentHousing.Domain.Models;

namespace StudentHousing.API.Mappers;

internal static class RoomMapper
{
    public static Room ToRoom(this CreateRoomRequest request)
    {
        return new Room
        {
            RoomId = request.Id,
            Floor = request.Floor,
            RoomNumber = request.RoomNumber
        };
    }
    
    public static RoomResponse ToResponse(this Room room)   
    {
        return new RoomResponse
        {
            Id = room.RoomId,
            Floor = room.Floor,
            RoomNumber = room.RoomNumber
        };
    }
}