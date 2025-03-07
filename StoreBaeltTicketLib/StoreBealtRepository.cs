using BridgeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLib
{
    public class StoreBealtRepository : IStoreBealtRepository
    {
        public static List<Vehicle> _list = new List<Vehicle>();

        public StoreBealtRepository()
        {
            
        }

        public Vehicle Add(Vehicle vehicle)
        {
            _list.Add(vehicle);
            return vehicle;
        }

        public List<Vehicle> GetAll()
        {
            return _list;
        }

        public List<Vehicle> GetAllByLicenseplate(string licenseplate)
        {
            return _list.Where(a => a.Licenseplate == licenseplate).ToList();

        }
    }
}
