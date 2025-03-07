using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronLib
{
    public class OresundMC : BridgeLibrary.Car
    {
        public override double BasePrice()
        {
            return 235;
        }

        public override double Price()
        {
            double price = BasePrice();
            if (Brobizz)
            {
                price = 92;
            }
            return price;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
