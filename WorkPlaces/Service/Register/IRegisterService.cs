using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Service.Register
{
    public interface IRegisterService
    {
        public string Register(string surname, string name, string login, string password, string passwordRepeat);
        public int GetIdByLogin(string login);
    }
}
