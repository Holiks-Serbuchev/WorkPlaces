using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Models;
using WorkPlaces.Service.Table;

namespace WorkPlaces.Controllers
{
    public class TableController : Controller
    {
        private ITableService _tableService;
        public TableController(ITableService tableService) => _tableService = tableService;
        private MainModel _mainModel = new MainModel();
        public IActionResult Index(string ExitButton)
        {
            _mainModel.login = Request.Cookies["Login"];
            _mainModel.role = Request.Cookies["Role"];
            _tableService.GetTables(_mainModel);
            if (ExitButton != null)
            {
                Response.Cookies.Delete("Login");
                Response.Cookies.Delete("Password");
                Response.Cookies.Delete("Role");
                return RedirectToAction("Index", "Home");
            }
            return View(_mainModel);
        }
        public IActionResult ExecuteQuery(string AddButton, string UpdateButton, string DeleteButton, string FirstDateTB, string SecondDateTB, string ReservationsTB, string EmployeeTB, string StatusTB)
        {
            _mainModel.login = Request.Cookies["Login"];
            _mainModel.role = Request.Cookies["Role"];
            if (AddButton != null)
                 _mainModel.message = _tableService.AddTable(EmployeeTB, FirstDateTB, SecondDateTB, StatusTB);
            else if (UpdateButton != null)
                _mainModel.message = _tableService.UpdateTable(ReservationsTB, EmployeeTB, FirstDateTB, SecondDateTB, StatusTB);
            else if (DeleteButton != null)
                _mainModel.message = _tableService.DeleteTable(ReservationsTB);
            _tableService.GetTables(_mainModel);
            return View("Index",_mainModel);
        }
    }
}
