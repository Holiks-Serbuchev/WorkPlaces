using System.Collections.Generic;
using System.Linq;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Login
{
    public class LoginRepository : ILoginRepository
    {
        private ApplicationContext applicationContext;
        public LoginRepository() => applicationContext = new ApplicationContext();

        public void Dispose()
        {
        }
        public IEnumerable<RolesModel> GetRoles() => applicationContext.roles.ToList();

        public IEnumerable<EmployeeModel> GetUsers() => applicationContext.employee.ToList();
    }
}
