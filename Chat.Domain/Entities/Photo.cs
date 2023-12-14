using Chat.Domain.Common;

namespace Chat.Domain.Entities
{
    public class Photo : Auditable
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }

        public int AccountId { get; set; }
        public Account? Account { get; set; }
    }
}
