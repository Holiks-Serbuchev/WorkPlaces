using System;
using System.Collections.Generic;
using WorkPlaces.Models;
namespace WorkPlaces.Repository.Devices
{
    public interface IDevicesRepository
    {
        public string AddDevice(string value);
        public string UpdateDevice(int id, string value);
        public string DeleteDevice(int id);
        public IEnumerable<DevicesModel> GetDevices();
    }
}
