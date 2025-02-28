using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarPriceMethodTest()
        {
            //arrange 
            Car c = new Car();

            //act
            double actual = c.Price();

            //assert 
            Assert.AreEqual(230, actual);
        }


        [TestMethod()]
        public void CarVehicleTypeMethodTest()
        {
            //arrange 
            Car c = new Car();

            //act
            string actual = c.VehicleType();

            //assert 
            Assert.AreEqual("Car", actual);
        }
    }
}