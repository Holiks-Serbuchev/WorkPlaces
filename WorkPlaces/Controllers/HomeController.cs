using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WorkPlaces.Models;
using WorkPlaces.Service.Login;

namespace WorkPlaces.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ILoginService _loginService;

        public HomeController(ILogger<HomeController> logger, ILoginService loginService)
        {
            _loginService = loginService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string login, string password, string register)
        {
            if (register == null)
            {
                if (login != null && password != null)
                {
                    IEnumerable<EmployeeModel> user = _loginService.GetUser(login, password);
                    if (user.Any() && user != null)
                    {
                        Response.Cookies.Append("Id", user.ElementAt(0).IDemployee.ToString(), new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                        Response.Cookies.Append("Login",login,new CookieOptions(){Path = "/",HttpOnly = false,Secure = true});
                        Response.Cookies.Append("Password", password, new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                        Response.Cookies.Append("Check", "", new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                        Response.Cookies.Append("Role", _loginService.GetRoleByID(user.ElementAt(0).RoleID), new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                        return RedirectToAction("Index", "Main");
                    }
                    else
                        return View("Index", "Invalid username or password");
                }
                else
                    return View("Index", "Invalid username or password");
            }
            else
                return RedirectToAction("Registration", "Registration");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
