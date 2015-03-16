using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory.Domain
{
    public abstract class RobotPart
    {
        public RobotPartCategory RobotPartCategory { get; private set; }

        protected RobotPart(RobotPartCategory robotPartCategory)
        {
            RobotPartCategory = robotPartCategory;
        }
    }
}
