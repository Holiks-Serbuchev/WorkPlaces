using System.Linq;
using WorkPlaces.Models;
using System;
using System.Collections.Generic;

namespace WorkPlaces.Repository.Roles
{
    public class RolesRepository : IRolesRepository
    {
        private ApplicationContext _applicationContext;
        public RolesRepository() => _applicationContext = new ApplicationContext();
        public string AddRole(string value)
        {
            try
            {
                RolesModel roles = new RolesModel{RoleName = value};
                _applicationContext.roles.AddRange(roles);
                _applicationContext.SaveChanges();
                return "Data successfully added";
            }
            catch (Exception) { return "There are problems with the server"; }
        }
        public string UpdateRole(int id, string value)
        {
            try
            {
                RolesModel roles = _applicationContext.roles.Where(i => i.RoleID == id).FirstOrDefault();
                roles.RoleName = value;
                _applicationContext.SaveChanges();
                return "Data successfully updated";
            }
            catch (Exception){ return "There are problems with the server"; }
        } 
        public string DeleteRole(int id)
        {
            try
            {
                RolesModel roles = _applicationContext.roles.Where(i => i.RoleID == id).FirstOrDefault();
                _applicationContext.Remove(roles);
                _applicationContext.SaveChanges();
                return "Data successfully deleted";
            }
            catch (Exception){ return "There are problems with the server"; }
        }
        public IEnumerable<RolesModel> GetRoles() => _applicationContext.roles.ToList();
    }
}
