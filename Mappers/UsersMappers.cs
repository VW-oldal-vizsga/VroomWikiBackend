using Models;
using VroomWiki.DTOs.Users;
namespace VroomWiki.Mappers
{
    public static class UsersMappers
    {
        public static UsersDTO ToUsersDTO(this User user)
        {
            return new UsersDTO
            {
                Id = user.Id,
                Email = user.Email,
                
            };
        }
    }
}
