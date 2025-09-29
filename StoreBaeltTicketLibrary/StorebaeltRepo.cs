using Bridge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltRepo : IStorebaeltRepo
    {
        private static List<vehicle> _tickets;

        public StorebaeltRepo()
        {
            _tickets = new List<vehicle>();
        }

        public void Buy(vehicle v)
        {
            _tickets.Add(v);
        }
        public List<vehicle> GetAll()
        {
            return _tickets;
        }
        public List<vehicle> GetAllByLicensePlate(string licensePlate)
        {
            return _tickets.Where(x => x.Licenseplate == licensePlate).ToList();
        }
    }
}
