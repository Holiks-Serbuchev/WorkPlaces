using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Models;

namespace WorkPlaces.Service.Roles
{
    public interface IRolesService
    {
        public string Action(string AddButton, string UpdateButton, string DeleteButton, string value, string titleRole);
        public IEnumerable<RolesModel> GetRoles();
    }
}
