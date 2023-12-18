using Microsoft.AspNetCore.SignalR;

namespace Chat.Web.Hubs
{
    public class ChatHub : Hub
    {


        public async Task SendToAllMessage(string user, string message)
            => await Clients.All.SendAsync("ReceiveMessage", user, Context.ConnectionId , message);
        
        public async Task SendToUserMessage(string id,string user, string message)
        {
            await Clients.Client(id).SendAsync("ReceiveMessageFromUser", user, message);
            await Clients.Caller.SendAsync("ReceiveMessageFromUser", user, message);

        }

        public async Task SendToGroupMessage(string groupName,string user, string message)
            => await Clients.Group(groupName).SendAsync("ReceiveMessageFromGroup", user, message);

        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("ReceiveNewUserConnectionToGroup", Context.ConnectionId);
        }
        
        public async Task JoinVideoRoom(string roomId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
            await Clients.Group(roomId).SendAsync("ReceiveNewUserConnectionToGroup", Context.ConnectionId);
        }
    }
}
