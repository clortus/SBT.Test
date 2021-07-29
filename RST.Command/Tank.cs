using System.Linq;

namespace RST.Command
{
    public class Tank : Unit, IUnit
    {
        public string Name
        {
            get
            {
                return "Tank";
            }
        }

        public override Action[] SupportedActions
        {
            get
            {
                return new[] {Action.Fire, Action.Move};
            }
        }

    }
}