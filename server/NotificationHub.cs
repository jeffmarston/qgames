using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace QGames
{
    public class NotificationHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            var connId = Context.ConnectionId;
            Console.WriteLine("Connected = " + connId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var connId = Context.ConnectionId;
            Console.WriteLine("Disconnected = " + connId);
            await base.OnDisconnectedAsync(exception);
        }

        public async Task Subscribe(string command)
        {
            await Clients.All.SendAsync("subscribed");
        }
    }
}
