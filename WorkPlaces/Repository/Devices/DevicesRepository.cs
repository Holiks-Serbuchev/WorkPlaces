using System;
using System.Collections.Generic;
using System.Linq;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Devices
{
    public class DevicesRepository : IDevicesRepository
    {
        private ApplicationContext _applicationContext;
        public DevicesRepository() => _applicationContext = new ApplicationContext();
        public string AddDevice(string value)
        {
            try
            {
                DevicesModel devices = new DevicesModel { DeviceName = value };
                _applicationContext.devices.AddRange(devices);
                _applicationContext.SaveChanges();
                return "Data successfully added";
            }
            catch (Exception) { return "There are problems with the server"; }
        }
        public string UpdateDevice(int id, string value)
        {
            try
            {
                DevicesModel devices = _applicationContext.devices.Where(i => i.DeviceID == id).FirstOrDefault();
                devices.DeviceName = value;
                _applicationContext.SaveChanges();
                return "Data successfully updated";
            }
            catch (Exception) { return "There are problems with the server"; }
        }
        public string DeleteDevice(int id)
        {
            try
            {
                DevicesModel devices = _applicationContext.devices.Where(i => i.DeviceID == id).FirstOrDefault();
                _applicationContext.Remove(devices);
                _applicationContext.SaveChanges();
                return "Data successfully deleted";
            }
            catch (Exception) { return "There are problems with the server"; }
        }
        public IEnumerable<DevicesModel> GetDevices() => _applicationContext.devices.ToList();
    }
}
