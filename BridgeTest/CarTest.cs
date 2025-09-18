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
            Car car = new Car();
            var result = car.Price();
            Assert.AreEqual(230, result);
        }
        [TestMethod]
        public void TestVehicleType()
        {
            Car car = new Car();
            var result = car.VehicleType();
            Assert.AreEqual("Car", result);
        }
    }
}
