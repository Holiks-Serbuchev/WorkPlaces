using System;
using System.Collections.Generic;
using WorkPlaces.Models;
using WorkPlaces.Repository.Devices;

namespace WorkPlaces.Service.Devices
{
    public class DevicesService : IDevicesService
    {
        private IDevicesRepository _devicesRepository;
        public DevicesService(IDevicesRepository devicesRepository) => _devicesRepository = devicesRepository;
        public string Action(string AddButton, string UpdateButton, string DeleteButton, string value, string titleDevice)
        {
            if (AddButton != null && titleDevice != null)
                return _devicesRepository.AddDevice(titleDevice);
            else if (UpdateButton != null && value != null && titleDevice != null)
                return _devicesRepository.UpdateDevice(Convert.ToInt32(value), titleDevice);
            else if (DeleteButton != null && value != null)
                return _devicesRepository.DeleteDevice(Convert.ToInt32(value));
            return "";
        }
        public IEnumerable<DevicesModel> GetDevices() => _devicesRepository.GetDevices();
    }
}
