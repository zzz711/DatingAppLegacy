using System.Threading.Tasks;
using DatingApp_API.Data;
using DatingApp_API.Models;
using Microsoft.AspNetCore.Mvc;


namespace DatingApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepo repo;
        public AuthController(IAuthRepo repo)
        {
            this.repo = repo;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            //validate request

            username = username.ToLower();
            
            if(await repo.UserExists(username))
                return BadRequest("Username already exists");

            var userToCreate = new User
            {
                Username = username
            };

            var createdUser = await repo.Register(userToCreate, password);

            return StatusCode(201);
        }
    }
}