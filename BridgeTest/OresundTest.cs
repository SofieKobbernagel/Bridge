using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;
using OresundBron;
namespace BridgeTest
{
    [TestClass]
    public sealed class OresundTest
    {
        [TestMethod]
        public void TestOresundCarBasePrice()
        {
            OresundCar car = new OresundCar("1234567", new DateTime(2025, 8, 8, 12, 0, 0), false);
            var result = car.Price();
            Assert.AreEqual(460, result);
        }
        [TestMethod]
        public void TestOresundCarPriceWithBroBizz()
        {
            OresundCar car = new OresundCar("1234567", new DateTime(2025, 8, 8, 12, 0, 0), true);
            var result = car.Price();
            Assert.AreEqual(178, result);
        }
        [TestMethod]
        public void TestOresundMCBasePrice()
        {
            OresundMC mc = new OresundMC("1234567", new DateTime(2025, 8, 8, 12, 0, 0), false);
            var result = mc.Price();
            Assert.AreEqual(235, result);
        }
        [TestMethod]
        public void TestOresundMCPriceWithBroBizz()
        {
            OresundMC mc = new OresundMC("1234567", new DateTime(2025, 8, 8, 12, 0, 0), true);
            var result = mc.Price();
            Assert.AreEqual(92, result);
        }
    }
}
