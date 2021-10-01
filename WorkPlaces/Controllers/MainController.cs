using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkPlaces.Controllers
{
    public class MainController : Controller
    {
        Models.MainModel mainModel = new Models.MainModel();
        private Service.Main.IMainService _mainService;
        public MainController(Service.Main.IMainService mainService) => _mainService = mainService;
        public IActionResult Index(string ExitButton)
        {
            mainModel.login = Request.Cookies["Login"];
            mainModel.role = Request.Cookies["Role"];
            mainModel.devices = new List<Models.DevicesModel>();
            _mainService.GetReservations(mainModel, DateTime.Now.ToString("yyyy-MM-dd"), Request.Cookies["Id"]);
            if (ExitButton != null)
            {
                Response.Cookies.Delete("Login");
                Response.Cookies.Delete("Password");
                Response.Cookies.Delete("Role");
                return RedirectToAction("Index", "Home");
            }
            return View(mainModel);
        }
        [HttpPost]
        public IActionResult Main(string TableSelect, string Submit, string DateTB, string BookButton, string ItemList)
        {
            mainModel.login = Request.Cookies["Login"];
            mainModel.role = Request.Cookies["Role"];
            mainModel.devices = new List<Models.DevicesModel>();
            mainModel.table = TableSelect;
            if (Submit != null && DateTB != null)
                _mainService.GetReservations(mainModel, DateTB, Request.Cookies["Id"]);
            else if (BookButton != null) 
            {
                string value = _mainService.GetDevices(mainModel, DateTB, TableSelect, Request.Cookies["Id"]);
                if (value != "true" && mainModel.role != "Администратор")
                {
                    _mainService.UpdateTable(Request.Cookies["Id"], Int32.Parse(TableSelect), DateTime.Parse(DateTB));
                    _mainService.GetDevices(mainModel, DateTB, TableSelect, Request.Cookies["Id"]);
                }
            }
            else if (ItemList != null)
                _mainService.EditDevices(mainModel, ItemList, TableSelect);
            return View("Index", mainModel);
        }
    }
}
