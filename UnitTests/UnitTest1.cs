using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using WorkPlaces;
using WorkPlaces.Models;
using WorkPlaces.Repository.Roles;
using WorkPlaces.Repository.Devices;
using WorkPlaces.Repository.Register;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DataBaseConnection()
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                Assert.AreEqual(true, applicationContext.Database.CanConnect());
            }
        }
        [TestMethod]
        public void GetRoles()
        {
            RolesRepository roles = new RolesRepository();
            CollectionAssert.AreNotEqual(new List<RolesModel>(), roles.GetRoles().ToList());
        }
        [TestMethod]
        public void GetDevices()
        {
            DevicesRepository devices = new DevicesRepository();
            CollectionAssert.AreNotEqual(new List<DevicesModel>(), devices.GetDevices().ToList());
        }
        [TestMethod]
        public void GetIdByLogin()
        {
            RegisterRepository registerRepository = new RegisterRepository();
            Assert.AreNotEqual("", registerRepository.GetIdByLogin("12"));
        }
    }
}
