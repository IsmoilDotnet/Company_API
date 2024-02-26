using Company.API.ExternalServices;
using Company.Application.Services.UserProfileServices;
using Company.Domain.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private readonly IUserProfileService _userService;

        public UserController(IUserProfileService userProfileService,IWebHostEnvironment env)
        {
            _env = env;
            _userService = userProfileService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateUser([FromForm] UserProfileDTO userProfileDTO, IFormFile picture)
        {
            UserProfileExternalService service = new UserProfileExternalService(_env);
            
            string picturePath = await service.AddPictureAndGetPath(picture);
            
            var result = await _userService.CreateUserProfileAsync(userProfileDTO, picturePath);
            
            return Ok(result);
        }
    }
}
