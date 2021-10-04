using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkPlaces.Service.Register;

namespace WorkPlaces.Controllers
{
    public class RegistrationController : Controller
    {
        private IRegisterService _register;
        public RegistrationController(IRegisterService register) => _register = register;
        public IActionResult Registration() => View();
        public IActionResult Register(string surname, string name, string login, string password, string back, string passwordRepeat)
        {
            if (back == null)
            {
                string value = _register.Register(surname, name, login, password, passwordRepeat);
                if (value == "True")
                {
                    Response.Cookies.Append("Id", _register.GetIdByLogin(login).ToString(), new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                    Response.Cookies.Append("Login", login, new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                    Response.Cookies.Append("Password", password, new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                    Response.Cookies.Append("Check", "", new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                    Response.Cookies.Append("Role", "Trainee", new CookieOptions() { Path = "/", HttpOnly = false, Secure = true });
                    return RedirectToAction("Index", "Main");
                }
                else if (!value.Contains("True") && value != "False")
                    return View("Registration", value);
                else
                    return View("Registration", "A user with this username already exists");
            }
            else
                return RedirectToAction("Index", "Home");
        }
    }
}
