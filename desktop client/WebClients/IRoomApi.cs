using Refit;
using StudentHousing.Contracts.Rooms.Requests;
using StudentHousing.Contracts.Rooms.Responses;
using StudentHousingApp.Helpers;

namespace StudentHousingApp.WebClients;

[Headers("Bearer")]
internal interface IRoomApi
{
    [Get(ApiEndpoints.Rooms.GetAll)]
    Task<IApiResponse<IEnumerable<RoomResponse>>> GetAllAsync();

    [Get(ApiEndpoints.Rooms.GetAvailableRooms)]
    Task<IApiResponse<IEnumerable<RoomResponse>>> GetAvailableAsync();

    [Post(ApiEndpoints.Rooms.Create)]
    Task<IApiResponse<RoomResponse>> CreateAsync([Body] CreateRoomRequest request);
}
