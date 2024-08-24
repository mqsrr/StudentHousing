using Refit;
using StudentHousing.Contracts.Complaints.Requests;
using StudentHousing.Contracts.Complaints.Responses;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;

namespace StudentHousingApp.WebClients;

[Headers("Bearer")]
internal interface IComplaintApi
{
    [Get(ApiEndpoints.Complaints.GetAll)]
    Task<IApiResponse<IEnumerable<ComplaintResponse>>> GetAllAsync();

    [Post(ApiEndpoints.Complaints.Create)]
    Task<IApiResponse<ComplaintResponse>> CreateAsync([Body] CreateComplaintRequest request);

    [Put(ApiEndpoints.Complaints.UpdateState)]
    Task<IApiResponse> UpdateStateAsync(Guid id, [Body] ComplaintState state);
}
