using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace RobotFactory.Domain
{
    [TestFixture]
    public class WorkerDroneTest
    {
        [Test]
        public void WorkerDroneIdentifiesRobotParts()
        {           
            var robotPart = new MockedRobotPart(RobotPartCategory.Assembly);
            var strategy = WorkerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<AssemblyRoomDeliveryStrategy>(strategy);

            robotPart = new MockedRobotPart(RobotPartCategory.Weapon);
            strategy = WorkerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<WeaponRoomDeliveryStrategy>(strategy);
        }

        [Test]
        public void WorkerDroneDropsOffRobotParts()
        {
            var workerDrone = new WorkerDrone();
            var robotPart = new MockedRobotPart(RobotPartCategory.Assembly);

            workerDrone.PickupRobotPart(robotPart);
            var destination = workerDrone.DropOffRobotParts();

            Assert.IsFalse(workerDrone.HasARobotPart());
            Assert.AreEqual(1, destination.RobotParts.Count);

            robotPart = new MockedRobotPart(RobotPartCategory.Weapon);

            workerDrone.PickupRobotPart(robotPart);
            destination = workerDrone.DropOffRobotParts();

            Assert.IsFalse(workerDrone.HasARobotPart());
            Assert.AreEqual(1, destination.RobotParts.Count);
        }
    }
}