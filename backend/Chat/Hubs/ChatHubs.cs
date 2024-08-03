using Chat.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Hubs;

public interface IChatClient
{
    Task ReceiveMessage(string userName, string message);
}

public class ChatHubs : Hub<IChatClient>
{
    public async Task JoinChat(UserConnection connection)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, connection.ChatRoom);

        await Clients
            .Group(connection.ChatRoom)
            .ReceiveMessage("Admin", $"{connection.UserName} присоединился к чату");
    }
}