using System.ComponentModel.DataAnnotations;

namespace VroomWiki.DTOs.Users
{
    public class UsersDTO
    {
        public required int Id { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
    }
}
