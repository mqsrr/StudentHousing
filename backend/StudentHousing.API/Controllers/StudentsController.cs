using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentHousing.API.Helpers;
using StudentHousing.API.Mappers;
using StudentHousing.Application.Repositories;

namespace StudentHousing.API.Controllers;

[ApiController]
[Authorize(Policy = JwtBearerDefaults.AuthenticationScheme)]
public sealed class StudentsController(IStudentRepository studentRepository) : ControllerBase
{
    private readonly IStudentRepository _studentRepository = studentRepository;

    [HttpGet(ApiEndpoints.Students.GetById)]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var student = await _studentRepository.GetStudentByIdAsync(id);
        return student is not null
            ? Ok(student.ToResponse())
            : NotFound();
    }

    [HttpGet(ApiEndpoints.Students.GetByUsername)]
    public async Task<IActionResult> GetByUsername([FromRoute] string username)
    {
        var student = await _studentRepository.GetStudentByUsernameAsync(username);
        return student is not null
            ? Ok(student.ToResponse())
            : NotFound();
    }
}