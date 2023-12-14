using Chat.API.Entities.Comman;

namespace Chat.API.Entities
{
    public class Account:Auditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
