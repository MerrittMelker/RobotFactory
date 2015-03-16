namespace RobotFactory.Domain
{
    public class DeliveryBayDeliveryStrategy : DeliveryStrategy
    {
        public DeliveryBayDeliveryStrategy() : base(null)
        {
        }

        public override FactoryRoom GetDestination()
        {
            return new DeliveryBay();
        }
    }
}