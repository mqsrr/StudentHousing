using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentHousing.API.Helpers;
using StudentHousing.API.Mappers;
using StudentHousing.Application.Repositories;
using StudentHousing.Contracts.Complaints.Requests;

namespace StudentHousing.API.Controllers;

[ApiController]
[Authorize(Policy = JwtBearerDefaults.AuthenticationScheme)]
public sealed class ComplaintsController(IComplaintRepository complaintRepository) : ControllerBase
{
    private readonly IComplaintRepository _complaintRepository = complaintRepository;

    [HttpGet(ApiEndpoints.Complaints.GetAll)]
    public async Task<IActionResult> GetAll()
    {
        var complaints = await _complaintRepository.GetAllComplaintsAsync();
        var responses = complaints.Select(complaint => complaint.ToResponse());
        
        return Ok(responses);
    }
    
    [HttpPost(ApiEndpoints.Complaints.Create)]
    public async Task<IActionResult> Create([FromBody] CreateComplaintRequest request)
    {
        bool isCreated = await _complaintRepository.CreateComplainAsync(request.ToComplaint());
        
        return isCreated
            ? Created()
            : BadRequest();
    }
}