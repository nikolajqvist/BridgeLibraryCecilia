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
    public class VehicleTests
    {
        [TestMethod()]
        public void TestLisensplateExeption()
        {
            //arrange 
            Car c = new Car();

            //act
            string actual = "12321233";

            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c.Licenseplate = actual);
        }

        
    }
}