using Chat.Domain.Common;

namespace Chat.Domain.Entities
{
    public class Chat : Auditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
