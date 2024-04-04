using Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uvali.API.DTOs;
using Uvali.API.Models;

namespace Uvali.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController(UvaliDBContext context) : ControllerBase
    {
        private readonly UvaliDBContext context = context;

        [HttpPost]
        public async Task<IActionResult> SingUp(UserRoleDTO request)
        {
            if (await context.Users.FirstOrDefaultAsync(u => u.Email == request.Email) != null)
                return BadRequest();

            await context.Users.AddAsync(new User()
            {
                Email = request.Email,
                Password = PasswordHelper.Hash(request.Password),
                Role = (int)request.Role
            });
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SingIn(UserDTO request)
        {
            if (await context.Users.FindAsync(request.Email,
                PasswordHelper.Hash(request.Password)) == null)
                return BadRequest();

            return Ok();
        }
    }
}