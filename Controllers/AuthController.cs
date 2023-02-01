using BaseAuthenticationWebAPI.Core.Applications.Interfaces.Services;
using BaseAuthenticationWebAPI.Core.Domain;

using Microsoft.AspNetCore.Mvc;

namespace BaseAuthenticationWebAPI.Controllers
{
    public class AuthController : ControllerBaseApi
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