using System.ComponentModel.DataAnnotations;
using Uvali.API.interfaces;
using Uvali.API.Enums;

namespace Uvali.API.DTOs
{
    public class UserDTO : IDTO
    {
        [EmailAddress]
        public required string Email { get; set; }

        [MinLength(6)]
        public required string Password { get; set; }
    }
}