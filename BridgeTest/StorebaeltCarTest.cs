using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeTest
{
    [TestClass]
    public sealed class StorebaeltCarTest
    {
        [TestMethod]
        public void TestPriceWeekendNoBrobizz()
        {
            StorebaeltCar storebaeltCar = new StorebaeltCar("1234567", new DateTime(2025, 9, 27, 12, 0, 0), false);
            var result = storebaeltCar.Price();
            var expected = 230 * 0.85; // 15% discount on 230
            Assert.AreEqual(expected, result,0.01);
        }
        [TestMethod]
        public void TestPriceWeekdayNoBrobizz()
        {
            StorebaeltCar storebaeltCar = new StorebaeltCar("1234567", new DateTime(2025, 9, 29, 12, 0, 0), false);
            var result = storebaeltCar.Price();
            var expected = 230; // No discount
            Assert.AreEqual(expected, result,0.01);
        }
        [TestMethod]
        public void TestPriceWeekdayWithBrobizz()
        {
            StorebaeltCar storebaeltCar = new StorebaeltCar("1234567", new DateTime(2025, 9, 29, 12, 0, 0), true);
            var result = storebaeltCar.Price();
            var expected = 230 * 0.9; // 10% discount on 230
            Assert.AreEqual(expected, result, 0.01);
        }
        [TestMethod]
        public void TestPriceWeekendWithBrobizz()
        {
            StorebaeltCar storebaeltCar = new StorebaeltCar("1234567", new DateTime(2025, 9, 28, 12, 0, 0), true);
            var result = storebaeltCar.Price();
            var expected = 230 * 0.85 * 0.9; // 15% discount on 230 and additional 10% with Brobizz
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
