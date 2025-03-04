using System.Transactions;

namespace BridgeLibrary
{
    /// <summary>
    /// Car er en subklasse og arver fra klassen vehicle 
    /// </summary>
    public class Car : Vehicle
    {

        /// <summary>
        /// VehicleType metode
        /// </summary>
        /// <returns>Hvilket køretøj det er</returns>
        public override string VehicleType()
        {
            return "Car";
        }

        /// <summary>
        /// basePrisen for Car
        /// </summary>
        /// <returns>Prisen</returns>
        public override double BasePrice()
        {
            return 230;
        }
    }
}
