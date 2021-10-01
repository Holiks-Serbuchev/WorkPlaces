using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Models
{
    public class MainModel
    {
        public string id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        ////////////////////////////////////
        public DateTime date { get; set; }
        public string table { get; set; }
        public IEnumerable<DevicesModel> devices { get; set; }
        public List<bool> devicesCheckBox = new List<bool>();
        public IEnumerable<RolesModel> roles { get; set; }
        public IEnumerable<ReservationsModel> reservations;
        public IEnumerable<EmployeeModel> employee;
        public IEnumerable<StatusesModel> statuses;
        public List<string> workPlaces = new List<string>();
        public string message { get; set; }
    }
}
