using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLib.Tests
{
    [TestClass()]
    public class StoreBaeltCarTests
    {
        [TestMethod()]
        public void TestPriceMethodWeekendDiscount()
        {
            //arrange 
            StoreBaeltCar c = new StoreBaeltCar();
            c.Brobizz = true;
            c.Date = new DateTime(2024, 3, 2);

            //act
            double actual = c.Price();

            //assert 
            Assert.AreEqual(175.95, actual, delta: 0.1);
        }
    }
}