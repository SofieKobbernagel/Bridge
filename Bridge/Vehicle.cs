using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class vehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        public abstract double Price();

        public abstract string VehicleType();
    }
}
