using Bridge;

namespace StoreBaeltTicketLibrary
{
    public interface IStorebaeltRepo
    {
        void Buy(vehicle v);
        List<vehicle> GetAll();
        List<vehicle> GetAllByLicensePlate(string licensePlate);
    }
}