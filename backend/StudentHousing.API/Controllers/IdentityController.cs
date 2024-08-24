using Microsoft.AspNetCore.Mvc;
using StudentHousing.API.Helpers;
using StudentHousing.API.Mappers;
using StudentHousing.Application.Repositories;
using StudentHousing.Application.Services;
using StudentHousing.Contracts.Auth.Requests;
using LoginRequest = StudentHousing.Contracts.Auth.Requests.LoginRequest;
using RegisterRequest = StudentHousing.Contracts.Auth.Requests.RegisterRequest;

namespace StudentHousing.API.Controllers;

[ApiController]
public sealed class IdentityController(IAuthenticationService authenticationService, IStudentRepository studentRepository) : ControllerBase
{
    private readonly IAuthenticationService _authenticationService = authenticationService;
    private readonly IStudentRepository _studentRepository = studentRepository;

    [HttpPost(ApiEndpoints.Auth.Login)]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var identity = await _authenticationService.LoginAsync(request.Username, request.Password);
        return identity is not null
            ? Ok(identity)
            : NotFound();
    }
    
    [HttpPost(ApiEndpoints.Auth.Register)]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        bool isEmailExists = await _authenticationService.IsEmailExists(request.Email);
        if (isEmailExists)
        {
            return BadRequest("Provided email already exists!");
        }
        
        var identityResponse = await _authenticationService.RegisterAsync(request.ToIdentity());
        if (identityResponse is null)
        {
            return BadRequest();
        }

        var studentToCreate = request.ToStudent();
        await _studentRepository.CreateStudentAsync(studentToCreate);

        return Ok(identityResponse);
    }
    
    [HttpPost(ApiEndpoints.Auth.RegisterAdmin)]
    public async Task<IActionResult> RegisterAdmin([FromBody] RegisterAdminRequest request)
    {
        bool isEmailExists = await _authenticationService.IsEmailExists(request.Email);
        if (isEmailExists)
        {
            return BadRequest("Provided email already exists!");
        }
        
        var identityResponse = await _authenticationService.RegisterAsync(request.ToIdentity());
        return identityResponse is not null
            ? Ok(identityResponse)
            : BadRequest();
    }
}