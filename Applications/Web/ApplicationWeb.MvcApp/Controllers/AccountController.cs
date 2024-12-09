using ApplicationWeb.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationWeb.MvcApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View("Login", new LoginViewModel());
        }
        public IActionResult Account()
        {
            return View("Account");
        }
        public IActionResult Logout()
        {
            return View("Login");
        }
    }
}
