using BridgeLibrary;

namespace StoreBaeltTicketLib
{
    public interface IStoreBealtRepository
    {
        Vehicle Add(Vehicle vehicle);
        List<Vehicle> GetAll();
        List<Vehicle> GetAllByLicenseplate(string licenseplate);
    }
}