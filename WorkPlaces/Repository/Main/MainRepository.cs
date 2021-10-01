using System;
using System.Collections.Generic;
using System.Linq;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Main
{
    public class MainRepository : IMainRepository
    {
        private ApplicationContext _applicationContext;
        public MainRepository() => _applicationContext = new ApplicationContext();
        public IEnumerable<Models.ReservationsModel> GetReservations() => _applicationContext.reservations.ToList();
        public IEnumerable<Models.StatusesModel> GetStatus() => _applicationContext.statuses.ToList();
        public IEnumerable<Models.DevicesModel> GetDevices() => _applicationContext.devices.ToList();
        public IEnumerable<Models.WorkPlacesModel> GetWorkPlaces(string tableID) => _applicationContext.workplaces.Where(i => i.RerservationID == Int32.Parse(tableID));
        public void AddDevices(string items, string tableID, string description)
        {
            try
            {
                WorkPlacesModel workPlaces = new WorkPlacesModel{DevicesID = Int32.Parse(items), RerservationID = Int32.Parse(tableID), Description = description};
                _applicationContext.workplaces.AddRange(workPlaces);
                _applicationContext.SaveChanges();
            }
            catch (Exception) { }
        }
        public void DeleteDevices(string items, string tableID)
        {
            try
            {
                WorkPlacesModel workPlaces = _applicationContext.workplaces.Where(i => i.DevicesID == Int32.Parse(items) && i.RerservationID == Int32.Parse(tableID)).FirstOrDefault();
                _applicationContext.Remove(workPlaces);
                _applicationContext.SaveChanges();
            }
            catch (Exception) { }
        }
        public string UpdateTable(string idEmployee, int id, DateTime dateTime)
        {
            try
            {
                ReservationsModel reservations = _applicationContext.reservations.Where(i => i.RerservationID == id).FirstOrDefault();
                reservations.IDemployee = Int32.Parse(idEmployee);
                reservations.StartDate = dateTime;
                reservations.EndDate = dateTime.AddDays(1);
                _applicationContext.SaveChanges();
                return "The data was successfully changed";
            }
            catch (Exception) { return ""; }
        }
    }
}
