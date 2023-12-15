using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Chat.Web.Hubs
{
    public class ChatHub : Hub
    {
        public async IAsyncEnumerable<int> Counter(
            int count,
            int delay,
            [EnumeratorCancellation]
            CancellationToken cancellationToken)
        {
            for (var i = 0; i < count; i++)
            {
                // Check the cancellation token regularly so that the server will stop
                // producing items if the client disconnects.
                cancellationToken.ThrowIfCancellationRequested();

                yield return i;

                // Use the cancellationToken in other APIs that accept cancellation
                // tokens so the cancellation can flow down to them.
                await Task.Delay(delay, cancellationToken);
            }
        }

        private async Task WriteItemsAsync(
            ChannelWriter<int> writer,
            int count,
            int delay,
            CancellationToken cancellationToken)
        {
            Exception localException = null;
            try
            {
                for (var i = 0; i < count; i++)
                {
                    await writer.WriteAsync(i, cancellationToken);

                    // Use the cancellationToken in other APIs that accept cancellation
                    // tokens so the cancellation can flow down to them.
                    await Task.Delay(delay, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                localException = ex;
            }
            finally
            {
                writer.Complete(localException);
            }
        }

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
            => await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
    }
}
