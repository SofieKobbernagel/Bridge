using Bridge;

namespace OresundBron
{
    public class OresundCar : Car
    {
        public OresundCar(string licenseplate, DateTime date, bool bro) : base(licenseplate, date, bro)
        {
            BasePrice = 460;
        }
        public override double Price()
        {
            if (HasBroBizz)
            {
                return 178;
            }
            return BasePrice;
        }
    }
}
