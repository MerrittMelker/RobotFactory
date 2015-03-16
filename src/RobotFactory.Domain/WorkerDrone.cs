using System;

namespace RobotFactory.Domain
{
    public class WorkerDrone
    {
        protected DeliveryStrategy DeliveryStrategy { get; set; }

        public static DeliveryStrategy IdentifyRobotPart(RobotPart robotPart)
        {
            switch (robotPart.RobotPartCategory)
            {
                case RobotPartCategory.Assembly:
                    return new AssemblyRoomDeliveryStrategy(robotPart);
                case RobotPartCategory.Weapon:
                    return new WeaponRoomDeliveryStrategy(robotPart);
                default:
                    throw new NotImplementedException();
            }
        }

        public void PickupRobotPart(RobotPart robotPart)
        {
            DeliveryStrategy = IdentifyRobotPart(robotPart);
        }

        public FactoryRoom DropOffRobotParts()
        {
            var factoryRoom = DeliveryStrategy.DeliverRobotParts();
            DeliveryStrategy = null;
            return factoryRoom;
        }

        public bool HasARobotPart()
        {
            return DeliveryStrategy != null;
        }
    }
}