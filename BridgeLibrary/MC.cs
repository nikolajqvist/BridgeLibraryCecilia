using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BridgeLibrary
{
    /// <summary>
    /// MC er en subklasse og arver fra klassen vehicle 
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// VehicleType metode
        /// </summary>
        /// <returns>Hvilket køretøj det er</returns>
        public override string VehicleType()
        {
            return "MC";
        }

        /// <summary>
        /// basePrisen for MC
        /// </summary>
        /// <returns>Prisen</returns>
        public override double BasePrice()
        {
            return 120;
        }
    }
}
