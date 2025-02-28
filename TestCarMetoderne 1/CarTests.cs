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

        [TestMethod()]
        public void CarPriceWithBrobizzMethodTest()
        {
            //arrange 
            Car c = new Car();
            c.Brobizz = true;

            //act
            double actual = c.Price();

            //assert 
            Assert.AreEqual(207, actual, delta: 0.1); //delta sørger for at testen bliver korrekt selvom der måske kan forekomme fejl i kommatallene - så længe at forskellen mellem 207 og actual er mindre end 0,1 vil testen bestå - vi bruger overload static assert 
        }
    }
}