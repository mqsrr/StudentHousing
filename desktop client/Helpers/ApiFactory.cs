using Refit;
using StudentHousingApp.MessageHandlers;

namespace StudentHousingApp.Helpers;

internal static class ApiFactory
{
    public static TEntity CreateNewInstance<TEntity>() 
    {
        return RestService.For<TEntity>(new HttpClient(new BearerAuthorizationMessageHandler())
        {
            BaseAddress = new Uri(ApiEndpoints.BaseAddress)
        }, new RefitSettings(new NewtonsoftJsonContentSerializer()));
    }
}
