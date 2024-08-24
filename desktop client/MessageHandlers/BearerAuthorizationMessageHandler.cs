using StudentHousingApp.Helpers;
using System.Net.Http.Headers;

namespace StudentHousingApp.MessageHandlers;
internal sealed class BearerAuthorizationMessageHandler : DelegatingHandler
{
    public BearerAuthorizationMessageHandler()
    {
        InnerHandler = new HttpClientHandler();
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", StaticStorage.JwtToken);
        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}
