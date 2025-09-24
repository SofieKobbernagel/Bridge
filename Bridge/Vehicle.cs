using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bridge
{
    public abstract class vehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        protected vehicle(string licenseplate, DateTime date)
        {
            if(licenseplate.Length != 7)
            {
                throw new ArgumentException("License plate must be 7 characters.");
            }
            Licenseplate = licenseplate;
            Date = date;
        }
        /// <summary>
        /// Gets the fixed price value
        /// </summary>
        /// <returns>The price as a double</returns>
        public abstract double Price();

        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle.</returns>
        public abstract string VehicleType();
    }
}
