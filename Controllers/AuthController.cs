using BaseAuthenticationWebAPI.Core.Applications.Interfaces.Services;
using BaseAuthenticationWebAPI.Core.Domain;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseAuthenticationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public ITokenService _tokenService { get; set; }

        public AuthController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public IActionResult Register(string username, string password)
        {
            var user = new User(username, password);
            return Ok(_tokenService.CreateToken(user));
        }
    }
}
