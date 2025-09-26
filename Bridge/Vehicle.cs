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
        public bool HasBroBizz { get; set; }
        public double BasePrice { get; set; }

        /// <summary>
        /// standard constructor for vehicles
        /// </summary>
        /// <param name="licenseplate">Licenseplate of the car</param>
        /// <param name="date">The date the ticket is issued</param>
        /// <param name="bro">Says weather or not you have brobizz</param>
        /// <exception cref="ArgumentException">Thows an exception if Licenseplate is not 7 characters</exception>
        protected vehicle(string licenseplate, DateTime date, bool bro)
        {
            if(licenseplate.Length != 7)
            {
                throw new ArgumentException("License plate must be 7 characters.");
            }
            Licenseplate = licenseplate;
            Date = date;
            HasBroBizz = bro;
        }
        /// <summary>
        /// Gets the fixed price value
        /// </summary>
        /// <returns>The price as a double</returns>
        public virtual double Price()
        {
            if (HasBroBizz)
            {
                return BasePrice * 0.90;
            }
            return BasePrice;
        }

        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle.</returns>
        public abstract string VehicleType();
    }
}
