using Refit;
using StudentHousing.Contracts.Students.Responses;
using StudentHousingApp.Helpers;

namespace StudentHousingApp.WebClients;

[Headers("Bearer")]
internal interface IStudentApi
{
    [Get(ApiEndpoints.Students.GetAll)]
    Task<IApiResponse<IEnumerable<StudentResponse>>> GetAllAsync();

    [Get(ApiEndpoints.Students.GetByUsername)]
    Task<IApiResponse<StudentResponse>> GetByUsernameAsync(string username);

    [Get(ApiEndpoints.Students.GetById)]
    Task<IApiResponse<StudentResponse>> GetByIdAsync(Guid id);
}
