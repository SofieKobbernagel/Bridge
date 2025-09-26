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
            MC mc = new MC("1234567", DateTime.Now, false);
            var result = mc.Price();
            Assert.AreEqual(120, result);
        }
        [TestMethod]
        public void TestVehicleType()
        {
            MC mc = new MC("1234567", DateTime.Now, false);
            var result = mc.VehicleType();
            Assert.AreEqual("MC", result);
        }
        [TestMethod]
        public void TestLicensePlateValidation_Valid()
        {
            MC mc = new MC("ABC1234", DateTime.Now, false);
            Assert.AreEqual("ABC1234", mc.Licenseplate);
        }
        [TestMethod]
        public void TestLicensePlateValidationTooLong_Invalid()
        {
            Assert.ThrowsException<ArgumentException>(() => new MC("12345678", DateTime.Now, false));
        }
        [TestMethod]
        public void TestLicensePlateValidationTooShort_Invalid()
        {
            Assert.ThrowsException<ArgumentException>(() => new MC("123456", DateTime.Now, false));
        }
        [TestMethod]
        public void TestPriceWithBroBizz()
        {
            MC mc = new MC("1234567", DateTime.Now, true);
            var result = mc.Price();
            Assert.AreEqual(108, result,0.01); // 10% discount on 120
        }
    }
}
