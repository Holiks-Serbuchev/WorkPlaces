using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaces.Repository.Main
{
    public interface IMainRepository
    {
        public IEnumerable<Models.ReservationsModel> GetReservations();
        public IEnumerable<Models.StatusesModel> GetStatus();
        public IEnumerable<Models.DevicesModel> GetDevices();
        public IEnumerable<Models.WorkPlacesModel> GetWorkPlaces(string tableID);
        public void AddDevices(string items, string tableID, string description);
        public void DeleteDevices(string items, string tableID);
        public string UpdateTable(string idEmployee, int id, DateTime dateTime);
    }
}
