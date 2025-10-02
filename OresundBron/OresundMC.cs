using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron
{
    public class OresundMC : MC
    {
        public OresundMC(string licenseplate, DateTime date, bool bro) : base(licenseplate, date, bro)
        {
            BasePrice = 235;
        }
        public override double Price()
        {
            if (HasBroBizz)
            {
                return 92;
            }
            return BasePrice;
        }
    }
}
