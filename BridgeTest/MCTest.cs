using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTest
{
    [TestClass]
    public sealed class MCTest
    {
        [TestMethod]
        public void TestPrice()
        {
            MC mc = new MC();
            var result = mc.Price();
            Assert.AreEqual(120, result);
        }
        [TestMethod]
        public void TestVehicleType()
        {
            MC mc = new MC();
            var result = mc.VehicleType();
            Assert.AreEqual("MC", result);
        }
    }
}
