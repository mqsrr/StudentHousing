using StudentHousing.Contracts.Auth.Requests;
using StudentHousing.Contracts.Rooms.Requests;
using StudentHousing.Contracts.Rooms.Responses;
using StudentHousingApp.Models;

namespace StudentHousingApp.Mappers;

internal static class RoomMapper
{
    public static Room ToRoom(this RoomResponse response)
    {
        return new Room
        {
            Id = response.Id,
            RoomNumber = response.RoomNumber,
            Floor = response.Floor
        };
    }    

    public static Room ToRoom(this CreateRoomRequest request)
    {
        return new Room
        {
            Id = request.Id,
            RoomNumber = request.RoomNumber,
            Floor = request.Floor
        };
    }    

    public static RegisterRoom ToRegisterRequest(this Room request)
    {
        return new RegisterRoom
        {
            Id = request.Id,
            RoomNumber = request.RoomNumber,
            Floor = request.Floor
        };
    }
}
