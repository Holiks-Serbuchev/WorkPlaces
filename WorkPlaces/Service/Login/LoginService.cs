using System.Linq;
using WorkPlaces.Models;
using System.Collections.Generic;
using WorkPlaces.Repository.Login;

namespace WorkPlaces.Service.Login
{
    public class LoginService : ILoginService
    {
        private ILoginRepository _loginRepo;
        public LoginService(ILoginRepository repository)
        {
            _loginRepo = repository;
        }
        public IEnumerable<EmployeeModel> GetUser(string login, string password)
        {
            IEnumerable<EmployeeModel> employees = _loginRepo.GetUsers();
            return employees.Where(i => i.Login == login).Where(i => i.Password == password);
        }
        public string GetRoleByID(int id) => _loginRepo.GetRoles().Where(i => i.RoleID == id).ElementAt(0).RoleName;
    }
}
