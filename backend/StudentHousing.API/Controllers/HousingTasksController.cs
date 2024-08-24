using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentHousing.API.Helpers;
using StudentHousing.API.Mappers;
using StudentHousing.Application.Repositories;
using StudentHousing.Contracts.HousingTasks.Requests;

namespace StudentHousing.API.Controllers;

[ApiController]
public sealed class HousingTasksController(IHousingTaskRepository housingTaskRepository) : ControllerBase
{
    private readonly IHousingTaskRepository _housingTaskRepository = housingTaskRepository;

    [HttpPost(ApiEndpoints.HousingTasks.Create)]
    [Authorize(Roles = "Admin", Policy = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> Create([FromRoute] Guid studentId, [FromBody] CreateHousingTaskRequest request)
    {
        bool isCreated = await _housingTaskRepository.CreateHousingTaskAsync(request.ToHousingTask(), studentId);
        return isCreated
            ? Created()
            : BadRequest();
    }
    
    [HttpPut(ApiEndpoints.HousingTasks.UpdateState)]
    [Authorize(Policy = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> UpdateState([FromRoute] Guid id, [FromBody] UpdateHousingTaskRequest request)
    {
        bool isUpdated = await _housingTaskRepository.UpdateTaskStateAsync(id, request.State);
        return isUpdated
            ? Ok()
            : BadRequest();
    }
    
    [HttpDelete(ApiEndpoints.HousingTasks.DeleteById)]
    [Authorize(Roles = "Admin", Policy = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> DeleteById([FromRoute] Guid id)
    {
        bool isDeleted = await _housingTaskRepository.DeleteHousingTaskByIdAsync(id);
        return isDeleted
            ? NoContent()
            : NotFound();
    }
}