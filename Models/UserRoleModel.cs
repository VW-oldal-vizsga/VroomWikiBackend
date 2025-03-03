using Models;

namespace VroomWiki.Models
{
    public class UserRoleModel
    {
        public int Id { get; set; }
        public User User { get; set; }
        public RoleModel Role { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
