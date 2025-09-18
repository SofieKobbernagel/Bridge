using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Motorcyckle class with properties Licensplate and date from the base class vehicle and methods to get price and vehicle type.
    /// </summary>
    public class MC : vehicle
    {
        /// <summary>
        /// Gets the fixed price value.
        /// </summary>
        /// <returns>The price (120) as a double</returns>
        public override double Price()
        {
            return 120;
        }
        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle. The default value is "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
