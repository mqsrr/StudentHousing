using Refit;
using StudentHousing.Contracts.GarbageDisposals.Requests;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;

namespace StudentHousingApp.WebClients;

[Headers("Bearer")]
internal interface IGarbageApi
{
    [Get(ApiEndpoints.Garbage.GetAll)]
    Task<IApiResponse<IEnumerable<GarbageDisposal>>> GetAllAsync();

    [Post(ApiEndpoints.Garbage.Create)]
    Task<IApiResponse> CreateAsync(CreateGarbageDisposal request);

    [Put(ApiEndpoints.Garbage.Update)]
    Task<IApiResponse> UpdateAsync(Guid id, [Body]UpdateGarbageDisposal request);

    [Delete(ApiEndpoints.Garbage.Delete)]
    Task<IApiResponse> DeleteByIdAsync(Guid id);
}
