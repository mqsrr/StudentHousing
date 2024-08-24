using Chat;
using Grpc.Net.Client;
using StudentHousingApp.Helpers;

namespace StudentHousingApp.Services;

internal sealed class ChatChannel
{
    private ChatService.ChatServiceClient _chatClient = null!;

    public async Task SendMessageAsync(ChatMessage message)
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:7204");
        _chatClient = new ChatService.ChatServiceClient(channel);

        await _chatClient.SendMessageAsync(message).ConfigureAwait(false);
    }
}
