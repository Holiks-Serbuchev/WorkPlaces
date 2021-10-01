using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Service.Devices;

namespace WorkPlaces.Controllers
{
    public class DevicesController : Controller
    {
        private IDevicesService _devicesService;
        public DevicesController(IDevicesService devicesService) => _devicesService = devicesService;
        public Models.MainModel mainModel = new Models.MainModel();
        public IActionResult Index(string ExitButton)
        {
            mainModel.login = Request.Cookies["Login"];
            mainModel.role = Request.Cookies["Role"];
            mainModel.devices = _devicesService.GetDevices();
            if (ExitButton != null)
            {
                Response.Cookies.Delete("Login");
                Response.Cookies.Delete("Password");
                Response.Cookies.Delete("Role");
                return RedirectToAction("Index", "Home");
            }
            return View(mainModel);
        }
        public IActionResult ExecuteQuery(string AddButton, string UpdateButton, string DeleteButton, string value, string titleDevice)
        {
            mainModel.message = _devicesService.Action(AddButton, UpdateButton, DeleteButton, value, titleDevice);
            mainModel.devices = _devicesService.GetDevices();
            mainModel.login = Request.Cookies["Login"];
            mainModel.role = Request.Cookies["Role"];
            return View("Index", mainModel);
        }
    }
}
