using System;
using System.Collections.Generic;
using System.Linq;
using WorkPlaces.Models;
using WorkPlaces.Repository.Main;

namespace WorkPlaces.Service.Main
{
    public class MainService : IMainService
    {
        private IMainRepository _mainRepository;
        public MainService(IMainRepository mainRepository) => _mainRepository = mainRepository;
        public string GetReservations(MainModel mainModel, string date, string id)
        {
            try
            {
                var check = CheckDate(date, Int32.Parse(id));
                mainModel.reservations = check;
                mainModel.date = check.ElementAt(0).StartDate;
                return "true";
            }
            catch (Exception)
            {
                var status = _mainRepository.GetStatus().FirstOrDefault(i => i.StatusName != "Удален");
                mainModel.reservations = _mainRepository.GetReservations().Where(i => i.StatusID == status.StatusID).Where(i => i.EndDate <= DateTime.Parse(date));
                mainModel.date = DateTime.Parse(date);
                return "false";
            }
        }
        public string GetDevices(MainModel mainModel, string date, string tableID, string id)
        {
            string text = GetReservations(mainModel, date, id);
            mainModel.devices = _mainRepository.GetDevices();
            var collection = _mainRepository.GetWorkPlaces(tableID);
            foreach (var item in mainModel.devices)
            {
                if (collection.Any(i => i.DevicesID == item.DeviceID))
                    mainModel.devicesCheckBox.Add(true);
                else
                    mainModel.devicesCheckBox.Add(false);
            }
            return text;
        }
        public void EditDevices(MainModel mainModel, string items, string tableID)
        {
            string[] collection = items.Split(',');
            mainModel.devices = _mainRepository.GetDevices();
            foreach (var item in mainModel.devices)
            {
                _mainRepository.DeleteDevices(item.DeviceID.ToString(), tableID);
                if (collection.Any(i => Int32.Parse(i) == item.DeviceID))
                    _mainRepository.AddDevices(item.DeviceID.ToString(), tableID, item.DeviceName);
            }
        }
        public IEnumerable<ReservationsModel> CheckDate(string dateTime, int id)
        {
            IEnumerable<ReservationsModel> reservationsModels = _mainRepository.GetReservations().Where(i => i.StartDate == DateTime.Parse(dateTime) && i.IDemployee == id);
            return reservationsModels;
        }
        public string UpdateTable(string idEmployee, int id, DateTime dateTime) => _mainRepository.UpdateTable(idEmployee, id, dateTime);
    }
}
