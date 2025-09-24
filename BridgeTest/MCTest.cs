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
            MC mc = new MC("1234567", new DateTime(2025, 8, 8, 12, 0, 0));
            var result = mc.Price();
            Assert.AreEqual(120, result);
        }
        [TestMethod]
        public void TestVehicleType()
        {
            MC mc = new MC("1234567", new DateTime(2025, 8, 8, 12, 0, 0));
            var result = mc.VehicleType();
            Assert.AreEqual("MC", result);
        }
        [TestMethod]
        public void TestLicensePlateValidation_Valid()
        {
            MC mc = new MC("ABC1234", DateTime.Now);
            Assert.AreEqual("ABC1234", mc.Licenseplate);
        }
        [TestMethod]
        public void TestLicensePlateValidationTooLong_Invalid()
        {
            Assert.ThrowsException<ArgumentException>(() => new MC("12345678", DateTime.Now));
        }
        [TestMethod]
        public void TestLicensePlateValidationTooShort_Invalid()
        {
            Assert.ThrowsException<ArgumentException>(() => new MC("123456", DateTime.Now));
        }
    }
}
