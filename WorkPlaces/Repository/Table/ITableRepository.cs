using System;
using System.Collections.Generic;
using WorkPlaces.Models;

namespace WorkPlaces.Repository.Table
{
    public interface ITableRepository
    {
        public IEnumerable<ReservationsModel> GetTables();
        public IEnumerable<StatusesModel> GetStatus();
        public IEnumerable<EmployeeModel> GetEmployees();
        public string AddTable(int idEmployee, DateTime startDate, DateTime endDate, int statusID);
        public string UpdateTable(int id, int idEmployee, DateTime startDate, DateTime endDate, int statusID);
        public string DeleteTable(int id);
    }
}