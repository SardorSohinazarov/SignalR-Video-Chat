using Microsoft.AspNetCore.SignalR;
using System.Text.RegularExpressions;

namespace VideoChat.Hubs
{
    public class ChatHub:Hub
    {
        public async Task JoinRoom(string roomId, string userId)
        {
            Users.list.Add(Context.ConnectionId, userId);
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
            await Clients.Group(roomId).SendAsync("user-connection", userId);
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            //Clients.All.SendAsync("user-disconnection", Users.list[Context.ConnectionId]);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
