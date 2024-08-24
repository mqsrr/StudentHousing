using StudentHousing.Contracts.Rooms.Requests;
using StudentHousingApp.Helpers;
using StudentHousingApp.Mappers;
using StudentHousingApp.Models;
using StudentHousingApp.WebClients;

namespace StudentHousingApp.Services;

internal sealed class RoomService
{
    private readonly IRoomApi _roomApi;

    public Action<Room>? OnRoomCreated { get; set; }

    public RoomService()
    {
        _roomApi = ApiFactory.CreateNewInstance<IRoomApi>();
    }

    public async Task<IEnumerable<Room>> GetAllAsync()
    {
        var response = await _roomApi.GetAllAsync();
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<Room>();
        }
        return response.Content!.Select(room => room.ToRoom());
    }

    public async Task<Room?> CreateAsync(CreateRoomRequest request)
    {
        var response = await _roomApi.CreateAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var createdRoom = response.Content!.ToRoom();
        OnRoomCreated?.Invoke(createdRoom);

        return createdRoom;
    }
}
