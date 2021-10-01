using WorkPlaces.Models;

namespace WorkPlaces.Service.Table
{
    public interface ITableService
    {
        public void GetTables(MainModel mainModel);
        public string AddTable(string idEmployee, string startDate, string endDate, string statusID);
        public string UpdateTable(string id, string idEmployee, string startDate, string endDate, string statusID);
        public string DeleteTable(string id);
    }
}