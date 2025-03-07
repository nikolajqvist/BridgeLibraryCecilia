using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOresundMCMethods
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void TestBasePrice()
        {
            //arrange 
            OresundCar o = new OresundCar();


            //act
            double actual = o.BasePrice();

            //assert 
            Assert.AreEqual(460, actual);
        }

        [TestMethod()]
        public void TestPriceWithBrobizz()
        {
            //arrange 
            OresundCar o = new OresundCar();
            o.Brobizz = true;

            //act
            double actual = o.Price();

            //assert 
            Assert.AreEqual(178, actual);
        }

        [TestMethod()]
        public void TestVehicletype()
        {
            //arrange 
            OresundCar o = new OresundCar();

            //act
            string actual = o.VehicleType();

            //assert 
            Assert.AreEqual("Oresund Car", actual);
        }
    }
}