using System;
using System.Collections.Generic;

namespace RobotFactory.Domain
{
    public class WorkerDrone
    {
        public List<RobotPart> RobotParts { get; set; }

        public DeliveryStrategy IdentifyRobotPart(RobotPart robotPart)
        {
            switch (robotPart.RobotPartCategory)
            {
                case RobotPartCategory.Assembly:
                    return new AssemblyRoomDeliveryStrategy();
                case RobotPartCategory.Weapon:
                    return new WeaponRoomDeliveryStrategy();
                default:
                    throw new NotImplementedException();
            }

        }
    }
}