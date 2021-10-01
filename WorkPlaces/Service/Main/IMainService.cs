using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Models;

namespace WorkPlaces.Service.Main
{
    public interface IMainService
    {
        public string GetReservations(MainModel mainModel, string date, string id);
        public string GetDevices(MainModel mainModel, string date, string tableID, string id);
        public void EditDevices(MainModel mainModel, string items, string tableID);
        public IEnumerable<ReservationsModel> CheckDate(string dateTime, int id);
        public string UpdateTable(string idEmployee, int id, DateTime dateTime);
    }
}
