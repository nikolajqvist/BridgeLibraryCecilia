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
    public class MCTests
    {
        [TestMethod()]
        public void MCPriceMethodTest()
        {
            //arrange 
            MC mc = new MC();

            //act
            double actual = mc.Price();

            //assert 
            Assert.AreEqual(120, actual);
        }


        [TestMethod()]
        public void MCVehicleTypeMethodTest()
        {
            //arrange 
            MC mc = new MC();

            //act
            string actual = mc.VehicleType();

            //assert 
            Assert.AreEqual("MC", actual);
        }

        [TestMethod()]
        public void MCPriceMethodWithBrobizzTest()
        {
            //arrange 
            MC mc = new MC();
            mc.Brobizz = true;

            //act
            double actual = mc.Price();

            //assert 
            Assert.AreEqual(108, actual);
        }
    }
}