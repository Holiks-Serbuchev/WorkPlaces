using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Repository.Register
{
    public interface IRegisterRepository
    {
        public bool RegisterUser(string surname, string name, string login, string password);
        public int GetIdByLogin(string login);
    }
}
