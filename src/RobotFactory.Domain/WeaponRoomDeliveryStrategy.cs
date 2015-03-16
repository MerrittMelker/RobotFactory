namespace RobotFactory.Domain
{
    public class WeaponRoomDeliveryStrategy : DeliveryStrategy
    {
        public WeaponRoomDeliveryStrategy(RobotPart robotPart) : base(robotPart)
        {
        }

        public override FactoryRoom GetDestination()
        {
            return new Armoury();
        }
    }
}