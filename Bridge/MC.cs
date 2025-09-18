using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Motorcyckle class with properties Licensplate and date and methods to get price and vehicle type.
    /// </summary>
    public class MC
    {
        public string Licenseplate;
        public DateTime Date;

        /// <summary>
        /// Gets the fixed price value.
        /// </summary>
        /// <returns>The price (120) as a double</returns>
        public double Price()
        {
            return 120;
        }
        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle. The default value is "MC".</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
