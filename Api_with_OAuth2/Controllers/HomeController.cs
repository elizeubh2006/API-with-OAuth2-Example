using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


using Api_with_OAuth2.Models;
using API_WITH_OAUTH2.Repositories;
using Microsoft.AspNetCore.Authorization;
using API_WITH_OAUTH2.Services;

namespace Api_with_OAuth2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User loginRequest, TokenService tokenService)
        {
            var user = UserRepository.Get(loginRequest.UserName, loginRequest.Password);

            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var token = tokenService.GenerateToken(user);
            return new User
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = "",
                Role = user.Role,
                Token = token
            };
        }

        [HttpGet("public")]
        [AllowAnonymous]
        public async Task<IActionResult> PublicEndpoint()
        {
            return Ok(new { message = "This is a public endpoint accessible to everyone." });
        }

        [HttpGet("manager")]
        [Authorize(Roles = "Gerente")]
        public async Task<IActionResult> ManagerEndpoint()
        {
            return Ok(new { message = "This endpoint is accessible only to managers." });
        }

        [HttpGet("buyer-manager")]
        [Authorize(Roles = "Comprador,Gerente")]
        public async Task<IActionResult> BuyerManagerEndpoint()
        {
            return Ok(new { message = "This endpoint is accessible to buyers and managers." });
        }

        [HttpGet("authenticated")]
        [Authorize]
        public async Task<IActionResult> AuthenticatedEndpoint()
        {
            return Ok(new { message = "This endpoint is accessible only to authenticated users." });
        }
    }

}

