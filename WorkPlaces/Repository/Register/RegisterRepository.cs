using System;
using System.Collections.Generic;
using System.Linq;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Register
{
    public class RegisterRepository : IRegisterRepository
    {
        ApplicationContext applicationContext;
        public RegisterRepository() => applicationContext = new ApplicationContext();
        public bool RegisterUser(string surname, string name, string login, string password)
        {
            try
            {
                EmployeeModel employee = new EmployeeModel
                {
                    Surname = surname,
                    Name = name,
                    Login = login,
                    Password = password,
                    RoleID = 5
                };
                applicationContext.employee.AddRange(employee);
                applicationContext.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }
        public int GetIdByLogin(string login) => applicationContext.employee.Where(i => i.Login == login).FirstOrDefault().IDemployee;
    }
}
