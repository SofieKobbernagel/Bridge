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
        /// Standard constructor for MC class inheriting from vehicle class.
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        /// <param name="bro"></param>
        /// Base price is set to 120.
        public MC(string licenseplate, DateTime date, bool bro) : base(licenseplate, date, bro)
        {
            Licenseplate = licenseplate;
            Date = date;
            HasBroBizz = bro;
            BasePrice = 120;
        }

        /// <summary>
        /// Gets the fixed price value.
        /// </summary>
        /// <returns>The price (120) as a double</returns>
        public override double Price()
        {
            return base.Price();
        }
      
        
        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle in this case "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
