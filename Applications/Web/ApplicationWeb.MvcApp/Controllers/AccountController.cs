using ApplicationWeb.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

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
            if (model.Login == "Irina" && model.Password == "1234")
            {
                return View("Account", new AccountViewModel() 
                {
                    Guid = Guid.NewGuid().ToString(), 
                    Name = "Irina",
                    FriendNames = new List<string>() {"Oleg", "Nata", "Slava" }
                });
            }

            return View("Login", model);

        }
        [HttpGet]
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
        public IActionResult Logout()
        {
            return View("Login");
        }
    }
}
