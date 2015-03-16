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
            var workerDrone = new WorkerDrone();
            
            var robotPart = new MockedRobotPart(RobotPartCategory.Assembly);
            var strategy = workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<AssemblyRoomDeliveryStrategy>(strategy);

            robotPart = new MockedRobotPart(RobotPartCategory.Weapon);
            strategy = workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<WeaponRoomDeliveryStrategy>(strategy);
        }

        private class MockedRobotPart : RobotPart
        {
            public MockedRobotPart(RobotPartCategory robotPartCategory) : base(robotPartCategory) { }
        }
    }


}