using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Models
{
    public class ReservationsModel
    {
        [Key]
        public int RerservationID { get; set; }
        public int IDemployee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusID { get; set; }
    }
}
