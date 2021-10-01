using System.Collections.Generic;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Roles
{
    public interface IRolesRepository
    {
        public string AddRole(string value);
        public string UpdateRole(int id, string value);
        public string DeleteRole(int id);
        public IEnumerable<RolesModel> GetRoles();
    }
}
