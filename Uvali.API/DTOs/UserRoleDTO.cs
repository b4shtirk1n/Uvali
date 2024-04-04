using Uvali.API.Enums;

namespace Uvali.API.DTOs
{
    public class UserRoleDTO : UserDTO
    {
        public required Role Role { get; set; }
    }
}