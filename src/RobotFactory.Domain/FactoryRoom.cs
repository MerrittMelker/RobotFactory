using System.Collections.Generic;
using System.Reflection.Emit;

namespace RobotFactory.Domain
{
    public abstract class FactoryRoom
    {
        protected FactoryRoom()
        {
            RobotParts = new List<RobotPart>();
        }

        public List<RobotPart> RobotParts { get; private set; }
    }
}