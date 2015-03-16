namespace RobotFactory.Domain
{
    internal class MockedRobotPart : RobotPart
    {
        public MockedRobotPart() : base(RobotPartCategory.Assembly) { }
        public MockedRobotPart(RobotPartCategory robotPartCategory) : base(robotPartCategory) { }
    }
}