using Microsoft.AspNetCore.SignalR;

namespace Chat.Web.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendToAllMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        
        public async Task SendToUserMessage(string id,string user, string message)
        {
            await Clients.User(id).SendAsync(user, message);
        }
    }
}
