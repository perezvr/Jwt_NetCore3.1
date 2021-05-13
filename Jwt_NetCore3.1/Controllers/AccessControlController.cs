using Jwt_NetCore3._1.Entities.Dto;
using Jwt_NetCore3._1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_NetCore3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessControlController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccessControlController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(GenerateTokenRequestDto model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }
    }
}
