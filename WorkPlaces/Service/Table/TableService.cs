using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Repository.Table;
using WorkPlaces.Models;

namespace WorkPlaces.Service.Table
{
    public class TableService : ITableService
    {
        private ITableRepository _tableRepository;
        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
        public void GetTables(MainModel mainModel)
        {
            var status = _tableRepository.GetStatus().FirstOrDefault(i => i.StatusName != "Удален");
            mainModel.reservations = _tableRepository.GetTables().Where(i => i.StatusID == status.StatusID);
            mainModel.employee = _tableRepository.GetEmployees();
            mainModel.statuses = _tableRepository.GetStatus();
        }
        public string AddTable(string idEmployee, string startDate, string endDate, string statusID)
        {
            if (idEmployee != null && startDate != null && endDate != null && statusID != null)
            {
                return _tableRepository.AddTable(Int32.Parse(idEmployee), DateTime.Parse(startDate), DateTime.Parse(endDate), Int32.Parse(statusID));
            }
            else
                return "Fill in all the fields";
        }
        public string UpdateTable(string id ,string idEmployee, string startDate, string endDate, string statusID)
        {
            if (id != null && idEmployee != null && startDate != null && endDate != null && statusID != null)
            {
                return _tableRepository.UpdateTable(Int32.Parse(id), Int32.Parse(idEmployee), DateTime.Parse(startDate), DateTime.Parse(endDate), Int32.Parse(statusID));
            }
            else
                return "Fill in all the fields";
        }
        public string DeleteTable(string id)
        {
            if (id != null)
                return _tableRepository.DeleteTable(Int32.Parse(id));
            else
                return "Fill in all the fields";
        }
    }
}
