using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronLib
{
    public class OresundCar : BridgeLibrary.Car
    {
        public override double BasePrice()
        {
            return 460;
        }

        public override double Price()
        {
            double price = BasePrice();
            if (Brobizz)
            {
                price = 178;
            }
            return price;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
