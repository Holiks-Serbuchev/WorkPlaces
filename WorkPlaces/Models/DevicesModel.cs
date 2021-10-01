using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Models
{
    public class DevicesModel
    {
        [Key]
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
    }
}
