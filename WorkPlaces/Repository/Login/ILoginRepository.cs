using System.Collections.Generic;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Login
{
    public interface ILoginRepository
    {
        public IEnumerable<EmployeeModel> GetUsers();
        public IEnumerable<RolesModel> GetRoles();
    }
}
