using System;
using System.Collections.Generic;
using System.Linq;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Table
{
    public class TableRepository : ITableRepository
    {
        private ApplicationContext _applicationContext;
        public TableRepository() => _applicationContext = new ApplicationContext();
        public IEnumerable<ReservationsModel> GetTables() => _applicationContext.reservations.ToList();
        public IEnumerable<StatusesModel> GetStatus() => _applicationContext.statuses.ToList();
        public IEnumerable<EmployeeModel> GetEmployees() => _applicationContext.employee.ToList();
        public string AddTable(int idEmployee, DateTime startDate, DateTime endDate, int statusID)
        {
            try
            {
                ReservationsModel reservations = new ReservationsModel { IDemployee = idEmployee, StartDate = startDate, EndDate = endDate, StatusID = statusID };
                _applicationContext.reservations.AddRange(reservations);
                _applicationContext.SaveChanges();
                return "The data was successfully added";
            }
            catch (Exception) { return ""; }
        }
        public string UpdateTable(int id, int idEmployee, DateTime startDate, DateTime endDate, int statusID)
        {
            try
            {
                ReservationsModel reservations = _applicationContext.reservations.Where(i => i.RerservationID == id).FirstOrDefault();
                reservations.IDemployee = idEmployee;
                reservations.StartDate = startDate;
                reservations.EndDate = endDate;
                reservations.StatusID = statusID;
                _applicationContext.SaveChanges();
                return "The data was successfully changed";
            }
            catch (Exception) { return ""; }
        }
        public string DeleteTable(int id)
        {
            try
            {
                ReservationsModel reservations = _applicationContext.reservations.Where(i => i.RerservationID == id).FirstOrDefault();
                _applicationContext.Remove(reservations);
                _applicationContext.SaveChanges();
                return "The data was successfully deleted";
            }
            catch (Exception) { return ""; }
        }
    }
}
