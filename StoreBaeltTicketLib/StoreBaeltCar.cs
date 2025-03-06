using BridgeLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StoreBaeltTicketLib
{
    public class StoreBaeltCar : Car
    {
        public override double Price()
        {
            double price = base.Price();
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price *= 0.85;
            }

            return price;
        }
    }
}
