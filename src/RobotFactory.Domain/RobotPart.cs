namespace RobotFactory.Domain
{
    public abstract class RobotPart
    {
        protected RobotPart(RobotPartCategory robotPartCategory)
        {
            RobotPartCategory = robotPartCategory;
        }

        public RobotPartCategory RobotPartCategory { get; private set; }
    }
}