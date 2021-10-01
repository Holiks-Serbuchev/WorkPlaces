using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Models;

namespace WorkPlaces.Service.Login
{
    public interface ILoginService
    {
        public IEnumerable<EmployeeModel> GetUser(string login, string password);
        public string GetRoleByID(int id);
    }
}
