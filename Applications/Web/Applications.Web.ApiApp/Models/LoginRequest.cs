using Swashbuckle.AspNetCore.Filters;

namespace Applications.Web.ApiApp.Models
{
    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class LoginRequestExample : IMultipleExamplesProvider<LoginRequest>
    {
        public IEnumerable<SwaggerExample<LoginRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Irina", new LoginRequest()
            {
                Login = "Irina",
                Password = "password"
            });

            yield return SwaggerExample.Create("Not Irina", new LoginRequest()
            {
                Login = "Oleg",
                Password = "password"
            });
        }
    }
}
 
