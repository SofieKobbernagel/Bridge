using Bridge;
using System.ComponentModel.DataAnnotations;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltCar : Car
    {
        public StorebaeltCar(string licenseplate, DateTime date, bool bro) : base(licenseplate, date, bro)
        {
        }

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
