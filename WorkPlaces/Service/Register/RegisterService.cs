using WorkPlaces.Repository.Register;

namespace WorkPlaces.Service.Register
{
    public class RegisterService : IRegisterService
    {
        private IRegisterRepository _register;
        public RegisterService(IRegisterRepository register) => _register = register;
        public string Register(string surname, string name, string login, string password, string passwordRepeat)
        {
            if (surname != null && name != null && login != null && password != null && passwordRepeat != null)
            {
                if (passwordRepeat == password)
                    return _register.RegisterUser(surname, name, login, password).ToString();
                else
                    return "Passwords must match";
            }
            else
                return "Incorrect data";
        }
        public int GetIdByLogin(string login) => _register.GetIdByLogin(login);
    }
}
