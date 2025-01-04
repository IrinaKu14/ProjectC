using ApplicationWeb.MvcApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Claims;

namespace ApplicationWeb.MvcApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login", new LoginViewModel());
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Login == "Irina" && model.Password == "1234")
                {
                    Login(model.Login);
                    //var claims = new List<Claim>()
                    //{
                    //    new Claim(ClaimTypes.Name, model.Login)
                    //};
                    //var ci = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                    //    ClaimsIdentity.DefaultRoleClaimType);
                    //var cp= new ClaimsPrincipal(ci);
                    //HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, cp, new
                    //    AuthenticationProperties
                    //{
                    //    IsPersistent = true,
                    //    ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                    //}).Wait();

                    return View("Account", new AccountViewModel()
                    {
                        Guid = Guid.NewGuid().ToString(),
                        Name = "Irina",
                        FriendNames = new List<string>() { "Oleg", "Nata", "Slava" }
                    });
                }
            }
            ModelState.AddModelError("", "Uncorrect lgin or password");
            return View("Login", model);

        }
        [HttpGet]
        [Authorize]
        public IActionResult Account(string guid)
        {
            var str = Guid.NewGuid().ToString();
            return View("Account", new AccountViewModel() 
            {
                Guid = str, 
                Name = str,
                FriendNames = new List<string>() { "Oleg", "Nata", "Slava" 
            }});
        }

        private void Login(string username)
        {

            var claims = new List<Claim>()
            {
              new Claim(ClaimTypes.Name, username)
            };
            var ci = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            var cp = new ClaimsPrincipal(ci);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, cp, new
                AuthenticationProperties
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
            }).Wait();

        }
        public IActionResult Logout()
        {
            return View("Login");
        }
    }
}
