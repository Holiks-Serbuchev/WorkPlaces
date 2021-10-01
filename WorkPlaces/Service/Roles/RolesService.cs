using System;
using System.Collections.Generic;
using WorkPlaces.Models;
using WorkPlaces.Repository.Roles;

namespace WorkPlaces.Service.Roles
{
    public class RolesService : IRolesService
    {
        private IRolesRepository _rolesRepository;
        public RolesService(IRolesRepository rolesRepository) => _rolesRepository = rolesRepository;
        public string Action(string AddButton, string UpdateButton, string DeleteButton, string value, string titleRole)
        {
            if (AddButton != null && titleRole != null)
                return _rolesRepository.AddRole(titleRole);   
            else if(UpdateButton != null && value != null && titleRole != null)
                return _rolesRepository.UpdateRole(Convert.ToInt32(value),titleRole);
            else if(DeleteButton != null && value != null)
                return _rolesRepository.DeleteRole(Convert.ToInt32(value));
            return "";
        }
        public IEnumerable<RolesModel> GetRoles() => _rolesRepository.GetRoles();
    }
}
