using Applications.Web.ApiApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace Applications.Web.ApiApp.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType<LoginResponse>(StatusCodes.Status200OK)]
        [ProducesResponseType<ErrorResponse>(StatusCodes.Status400BadRequest)]
        [SwaggerRequestExample(typeof(LoginRequest), typeof(LoginRequestExample))]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Login == "Irina")
            {
                return Ok(new LoginResponse()
                {
                    Token = $"hello {request.Login}"
                });
            }

            return BadRequest( new ErrorResponse()
                { 
                    Message ="User not found"
                });
        }
        

        [HttpGet("getname/{login}")]
        public string GetName(string login)
        {
            return $"Irina {login}";
        }


        [HttpGet]
        [Route("second-name")]
        public string GetSecondName()
        {
            return "Ivanova";
        }
    }
}
