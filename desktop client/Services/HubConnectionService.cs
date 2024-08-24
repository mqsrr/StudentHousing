using Microsoft.AspNetCore.SignalR.Client;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;

namespace StudentHousingApp.Services;

internal sealed class HubConnectionService : IAsyncDisposable
{
    private readonly HubConnection _hubConnection;

    public bool IsConnected => _hubConnection.State is HubConnectionState.Connected;

    public HubConnectionService(Student student)
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl(ApiEndpoints.BaseAddress + "/chat")
            .WithAutomaticReconnect()
            .Build();
    }

    public async Task JoinPartyAsync(Guid partyId)
    {
        await _hubConnection.InvokeAsync("JoinParty", partyId);
    }    

    public async Task LeavePartyAsync(Guid partyId)
    {
        await _hubConnection.InvokeAsync("LeaveParty", partyId);
    }

    public async Task StartConnectionAsync()
    {
        if (IsConnected)
        {
            return;
        }

        await _hubConnection.StartAsync();
    }

    public void OnMessageSent(Action<Models.Message> onMessageSent)
    {
        _hubConnection.On("MessageSent", onMessageSent);
    }

    public async ValueTask DisposeAsync()
    {
        await _hubConnection.StopAsync();
    }
}
