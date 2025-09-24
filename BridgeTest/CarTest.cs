using Bridge;
using System.ComponentModel.DataAnnotations;

namespace BridgeTest
{
    [TestClass]
    public sealed class CarTest
    {
        [TestMethod]
        public void TestPrice()
        {
            Car car = new Car("1234567", new DateTime(2025, 8, 8, 12, 0, 0));
            var result = car.Price();
            Assert.AreEqual(230, result);
        }
        [TestMethod]
        public void TestVehicleType()
        {
            Car car = new Car("1234567", new DateTime(2025, 8, 8, 12, 0, 0));
            var result = car.VehicleType();
            Assert.AreEqual("Car", result);
        }
        [TestMethod]
        public void TestLicensePlateValidation_Valid()
        {
            Car car = new Car("ABC1234", DateTime.Now);
            Assert.AreEqual("ABC1234", car.Licenseplate);
        }
        [TestMethod]
        public void TestLicensePlateValidationTooLong_Invalid()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("12345678", DateTime.Now));
        }
        [TestMethod]
        public void TestLicensePlateValidationTooShort_Invalid()
        {
            Assert.ThrowsException<ArgumentException>(() => new Car("123456", DateTime.Now));
        }
    }
}
