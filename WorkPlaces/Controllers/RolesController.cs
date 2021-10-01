using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Service.Roles;

namespace WorkPlaces.Controllers
{
    public class RolesController : Controller
    {
        private IRolesService _rolesService;
        public RolesController(IRolesService rolesService) => _rolesService = rolesService;
        Models.MainModel mainModel = new Models.MainModel();
        public IActionResult Index(string ExitButton)
        {
            mainModel.login = Request.Cookies["Login"];
            mainModel.role = Request.Cookies["Role"];
            mainModel.roles = _rolesService.GetRoles();
            if (ExitButton != null)
            {
                Response.Cookies.Delete("Login");
                Response.Cookies.Delete("Password");
                Response.Cookies.Delete("Role");
                return RedirectToAction("Index", "Home");
            }
            return View(mainModel);
        }
        public IActionResult ExecuteQuery(string AddButton, string UpdateButton, string DeleteButton, string value, string titleRole)
        {
            mainModel.message = _rolesService.Action(AddButton, UpdateButton, DeleteButton, value, titleRole);
            mainModel.roles = _rolesService.GetRoles();
            mainModel.login = Request.Cookies["Login"];
            mainModel.role = Request.Cookies["Role"];
            return View("Index", mainModel);
        }
    }
}
