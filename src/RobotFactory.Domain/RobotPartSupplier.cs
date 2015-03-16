using System.Collections.Generic;

namespace RobotFactory.Domain
{
    public class RobotPartSupplier
    {
        public List<RobotPart> RobotParts { get; set; }

        public void DeliverRobotParts(DeliveryBay deliveryBay)
        {
            deliveryBay.RobotParts.AddRange(RobotParts);
            RobotParts.Clear();
        }
    }
}