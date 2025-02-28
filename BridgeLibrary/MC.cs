using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLibrary
{
    /// <summary>
    /// MC er en subklasse og arver fra klassen vehicle 
    /// </summary>
    public class MC : Vehicle
    {
        public override string VehicleType()
        {
            return "MC";
        }

        public override double Price()
        {
            return 120;
        }
    }
}
