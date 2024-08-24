using Refit;
using StudentHousing.Contracts.Auth.Requests;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;

namespace StudentHousingApp.WebClients;

internal interface IAuthenticationApi
{
    [Post(ApiEndpoints.Auth.Login)]
    Task<IApiResponse<IdentityResponse>> LoginAsync([Body] LoginRequest request);

    [Post(ApiEndpoints.Auth.Register)]
    Task<IApiResponse<IdentityResponse>> RegisterAsync([Body] RegisterRequest request);

    [Post(ApiEndpoints.Auth.RegisterAdmin)]
    Task<IApiResponse<IdentityResponse>> RegisterAdminAsync([Body] RegisterAdminRequest request);
}
