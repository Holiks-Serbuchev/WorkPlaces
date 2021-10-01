using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Models
{
    public class StatusesModel
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
