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
    public class OresundMCTests
    {
        [TestMethod()]
        public void TestBasePrice()
        {
            //arrange 
            OresundMC o = new OresundMC();


            //act
            double actual = o.BasePrice();

            //assert 
            Assert.AreEqual(235, actual);
        }

        [TestMethod()]
        public void TestPriceWithBrobizz()
        {
            //arrange 
            OresundMC o = new OresundMC();
            o.Brobizz = true;

            //act
            double actual = o.Price();

            //assert 
            Assert.AreEqual(92, actual);
        }

        [TestMethod()]
        public void TestVehicletype()
        {
            //arrange 
            OresundMC o = new OresundMC();

            //act
            string actual = o.VehicleType();

            //assert 
            Assert.AreEqual("Oresund MC", actual);
        }
    }
}