using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Models
{
    public class RolesModel
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
