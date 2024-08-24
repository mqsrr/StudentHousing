using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentHousing.API.Helpers;
using StudentHousing.API.Mappers;
using StudentHousing.Application.Repositories;
using StudentHousing.Contracts.Rooms;

namespace StudentHousing.API.Controllers;

[ApiController]
public sealed class RoomsController(IRoomRepository roomRepository) : ControllerBase
{
    private readonly IRoomRepository _roomRepository = roomRepository;

    [HttpGet(ApiEndpoints.Rooms.GetAll)]
    public async Task<IActionResult> GetAll()
    {
        var rooms = await _roomRepository.GetAllRoomsAsync();
        var responses = rooms.Select(room => room.ToResponse());

        return Ok(responses);
    }
    
    [HttpGet(ApiEndpoints.Rooms.GetAvailableRooms)]
    public async Task<IActionResult> GetAvailable()
    {
        var rooms = await _roomRepository.GetAvailableRoomsAsync();
        var responses = rooms.Select(room => room.ToResponse());    
        
        return Ok(responses);
    }
    
    [HttpPost(ApiEndpoints.Rooms.Create)]
    [Authorize(Roles = "Admin", Policy = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> Create([FromBody]CreateRoomRequest request)
    {
        var roomToCreate = request.ToRoom();
        bool isCreated = await _roomRepository.CreateRoomAsync(roomToCreate);
        
        return isCreated
            ? Ok(roomToCreate.ToResponse())
            : BadRequest();
    }
}