using Chat.API.Entities.Comman;

namespace Chat.API.Entities
{
    public class Message:Auditable
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
