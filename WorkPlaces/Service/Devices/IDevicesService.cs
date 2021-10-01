using System.Collections.Generic;
using WorkPlaces.Models;

namespace WorkPlaces.Service.Devices
{
    public interface IDevicesService
    {
        public string Action(string AddButton, string UpdateButton, string DeleteButton, string value, string titleRole);
        public IEnumerable<DevicesModel> GetDevices();
    }
}
