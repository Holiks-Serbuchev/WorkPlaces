using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Models
{
    public class WorkPlacesModel
    {
        [Key]
        public int IDWorkplace { get; set; }
        public int RerservationID { get; set; }
        public int DevicesID { get; set; }
        public string Description { get; set; }
    }
}
