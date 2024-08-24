using Refit;
using StudentHousing.Contracts.HousingTasks.Requests;
using StudentHousing.Contracts.HousingTasks.Responses;
using StudentHousingApp.Helpers;

namespace StudentHousingApp.WebClients;

[Headers("Bearer")]
internal interface IHousingTaskApi
{
    [Post(ApiEndpoints.HousingTasks.Create)]
    Task<IApiResponse<HousingTaskResponse>> CreateAsync(Guid studentId, [Body] CreateHousingTaskRequest request);

    [Put(ApiEndpoints.HousingTasks.UpdateState)]
    Task<IApiResponse> UpdateStateAsync(Guid studentId, Guid id, [Body] UpdateHousingTaskRequest request);

    [Delete(ApiEndpoints.HousingTasks.DeleteById)]
    Task<IApiResponse> DeleteAsync(Guid studentId, Guid id, [Body] UpdateHousingTaskRequest request);
}
