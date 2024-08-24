using Refit;
using StudentHousing.Contracts.Parties.Requests;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;

namespace StudentHousingApp.WebClients;

[Headers("Bearer")]
internal interface IPartyApi
{
    [Get(ApiEndpoints.Party.GetAll)]
    Task<IApiResponse<IEnumerable<Party>>> GetAllAsync();

    [Get(ApiEndpoints.Party.GetById)]
    Task<IApiResponse<Party>> GetByIdAsync(Guid id);

    [Post(ApiEndpoints.Party.Create)]
    Task<IApiResponse<Party>> CreateAsync([Body] CreatePartyRequest request);

    [Post(ApiEndpoints.Party.AddStudentToParty)]
    Task<IApiResponse> AddStudentToPartyAsync(Guid id, [Query] Guid studentId);

    [Delete(ApiEndpoints.Party.RemoveStudentFromParty)]
    Task<IApiResponse> RemoveStudentFromPartyAsync(Guid id, [Query] Guid studentId);
}
