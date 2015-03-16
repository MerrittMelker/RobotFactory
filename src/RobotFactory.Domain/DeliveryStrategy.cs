namespace RobotFactory.Domain
{
    public abstract class DeliveryStrategy
    {
        private readonly RobotPart _robotPart;
        private FactoryRoom _destination;

        protected DeliveryStrategy(RobotPart robotPart)
        {
            _robotPart = robotPart;
        }

        public abstract FactoryRoom GetDestination();

        public FactoryRoom DeliverRobotParts()
        {
            if (_destination == null) _destination = GetDestination();
            _destination.RobotParts.Add(_robotPart);
            return _destination;
        }
    }
}