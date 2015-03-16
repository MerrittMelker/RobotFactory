using System;
using System.Collections.Generic;

namespace RobotFactory.Domain
{
    public class WorkerDrone
    {
        private List<DeliveryStrategy> _deliveryStrategies = new List<DeliveryStrategy>();

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
            _deliveryStrategies.Add(IdentifyRobotPart(robotPart));
        }

        public void DropOffRobotParts()
        {
            foreach(var strategy in _deliveryStrategies) strategy.DeliverRobotParts();
            _deliveryStrategies.Clear();
        }

        public int GetRobotPartCount()
        {
            return _deliveryStrategies.Count;
        }
    }
}