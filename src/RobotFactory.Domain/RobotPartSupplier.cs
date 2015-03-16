using System.Collections.Generic;

namespace RobotFactory.Domain
{
    public class RobotPartSupplier
    {
        public List<RobotPart> RobotParts { get; set; }

        public void DeliverRobotParts(DeliveryBay deliveryBay)
        {
            deliveryBay.RobotParts = new List<RobotPart>(RobotParts);
            RobotParts.Clear();
        }
    }
}