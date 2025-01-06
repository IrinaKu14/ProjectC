using Applications.Web.Shared.Models;

using Swashbuckle.AspNetCore.Filters;

namespace Applications.Web.ApiApp.Models
{
 
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
 
