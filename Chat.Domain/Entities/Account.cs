using Chat.Domain.Common;

namespace Chat.Domain.Entities
{
    public class Account : Auditable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Photo>? Photos { get; set; }

        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
