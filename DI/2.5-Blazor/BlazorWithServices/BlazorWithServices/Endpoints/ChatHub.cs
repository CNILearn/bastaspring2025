using Microsoft.AspNetCore.SignalR;

namespace BlazorWithServices.Endpoints;

public class ChatHub : Hub
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("BroadcastMessage", user, message);
    }
}
