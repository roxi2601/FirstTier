using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FirstTier.Chat
{
    public class ChatHub : Hub
    {
        public const string HubUrl = "/chat";

        // This method broadcasts a message to all clients.
        public async Task Broadcast(string username, string message)
        {
            await Clients.All.SendAsync("Broadcast", username, message);
        }
        // This method sends a message back to the caller.
        public async Task Echo(string username, string message) =>
            await Clients.Client(Context.ConnectionId)
                .SendAsync("echo", username, $"{message} (echo from server)");
        
        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"{Context.ConnectionId} connected");
            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception e)
        {
            Console.WriteLine($"Disconnected {e?.Message} {Context.ConnectionId}");
            await base.OnDisconnectedAsync(e);
        }
    }
}