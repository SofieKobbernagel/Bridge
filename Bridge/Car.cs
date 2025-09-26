using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bridge
{
    /// <summary>
    /// Car class with properties Licensplate and date from the base class vehicle and methods to get price and vehicle type.
    /// </summary>
    public class Car : vehicle
    {
        /// <summary>
        /// standard constructor for Car class inheriting from vehicle class.
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        /// <param name="bro"></param>
        /// Base price is set to 230.
        public Car(string licenseplate, DateTime date, bool bro) : base(licenseplate, date, bro)
        {
            Licenseplate = licenseplate;
            Date = date;
            HasBroBizz = bro;
            BasePrice = 230;
        }
        /// <summary>
        /// Gets the fixed price value.
        /// </summary>
        /// <returns>The price (230) as a double</returns>
        public override double Price()
        {
            return base.Price();
        }

        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle in this case "Car".</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
