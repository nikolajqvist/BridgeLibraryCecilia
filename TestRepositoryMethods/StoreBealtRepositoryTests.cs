using BridgeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOresundMCMethods
{
    [TestClass()]
    public class StoreBealtRepositoryTests
    {
        [TestMethod()]
        public void TestAddCar()
        {
            // Arrange
            var repository = new StoreBealtRepository();
            var car = new StoreBaeltCar { Licenseplate = "AB12345", Brobizz = true };

            // Act
            var actual = repository.Add(car);

            // Asser
            Assert.AreEqual("AB12345", actual.Licenseplate);
        }

        [TestMethod()]
        public void TestAddMC()
        {
            // Arrange
            var repository = new StoreBealtRepository();
            var MC = new MC { Licenseplate = "AB12345", Brobizz = true };

            // Act
            var actual = repository.Add(MC);

            // Asser
            Assert.AreEqual("AB12345", actual.Licenseplate);
        }

        [TestMethod()]
        public void TestGetAll()
        {
            // Arrange
            StoreBealtRepository s = new StoreBealtRepository();
            var car = new Car { Licenseplate = "AB12345", Brobizz = true };
            var mc = new MC { Licenseplate = "AB39245", Brobizz = false };

            // Act
            s.Add(car);
            s.Add(mc);
            var result = s.GetAll();

            // Asser
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod()]
        public void TestGetAllByLicenseplate()
        {
            // Arrange
            StoreBealtRepository s = new StoreBealtRepository();
            var car = new Car { Licenseplate = "AB12345", Brobizz = true };
            var mc = new MC { Licenseplate = "AB39245", Brobizz = false };
            var car2 = new Car { Licenseplate = "AB12345", Brobizz = true };

            // Act
            s.Add(car);
            s.Add(mc);
            s.Add(car2);
            var result = s.GetAllByLicenseplate("AB12345");

            // Asser
            Assert.AreEqual(2, result.Count);
        }

        
    }
}