namespace RobotFactory.Domain
{
    public class AssemblyRoomDeliveryStrategy : DeliveryStrategy
    {
        public AssemblyRoomDeliveryStrategy(RobotPart robotPart) : base(robotPart)
        {
        }

        public override FactoryRoom GetDestination()
        {
            return new AssemblyRoom();
        }
    }
}