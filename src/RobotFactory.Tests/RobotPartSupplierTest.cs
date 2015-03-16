using System.Collections.Generic;
using NUnit.Framework;

namespace RobotFactory.Domain
{
    [TestFixture]
    public class RobotPartSupplierTest
    {
        [Test]
        public void RobotPartSupplierTestDeliversRobotParts()
        {
            var robotPartSupplier = new RobotPartSupplier
            {
                RobotParts = new List<RobotPart> { new MockedRobotPart(), new MockedRobotPart() }
            };

            var deliveryBay = new DeliveryBay();
            robotPartSupplier.DeliverRobotParts(deliveryBay);

            Assert.AreEqual(0, robotPartSupplier.RobotParts.Count);
            Assert.AreEqual(2, deliveryBay.RobotParts.Count);
        }
    }
}