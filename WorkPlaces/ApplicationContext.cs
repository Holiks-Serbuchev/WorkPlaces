using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkPlaces.Models;

namespace WorkPlaces
{
    public class ApplicationContext : DbContext
    {
        public DbSet<EmployeeModel> employee { get; set; }
        public DbSet<DevicesModel> devices { get; set; }
        public DbSet<ReservationsModel> reservations { get; set; }
        public DbSet<RolesModel> roles { get; set; }
        public DbSet<StatusesModel> statuses { get; set; }
        public DbSet<WorkPlacesModel> workplaces { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=*****;user=*****;password=*****;database=*****;", new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
