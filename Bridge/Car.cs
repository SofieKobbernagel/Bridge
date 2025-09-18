using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bridge
{
    /// <summary>
    /// Car class with properties Licensplate and date and methods to get price and vehicle type.
    /// </summary>
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the fixed price value.
        /// </summary>
        /// <returns>The price (230) as a double</returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle. The default value is "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
