using Chat.Domain.Common;

namespace Chat.Domain.Entities
{
    public class Message:Auditable
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int SenderId { get; set; }
        public Account? Sender { get; set; }
    }
}
