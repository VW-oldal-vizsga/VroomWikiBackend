using Models;

namespace VroomWiki.Models
{
    public class SessionModel
    {
        public int Id { get; set; }
        public required User User { get; set; }
        public required string Token { get; set; }
        public DateTime LastAccess { get; set; }
    }
}
