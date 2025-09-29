using Bridge;
using System.ComponentModel.DataAnnotations;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltCar : Car
    {
        public StorebaeltCar(string licenseplate, DateTime date, bool bro) : base(licenseplate, date, bro)
        {
        }
        /// <summary>
        /// Returns the price of a Storebaelt car ticket, applying discounts for weekends and Brobizz.
        /// </summary>
        /// <returns>the price of ticket as double</returns>
        public override double Price()
        {
            double finalPrice = BasePrice;
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                finalPrice *= 0.85;
            }
            if (HasBroBizz)
            {
                finalPrice *= 0.9;
            }
            return finalPrice;
        }
    }
}
