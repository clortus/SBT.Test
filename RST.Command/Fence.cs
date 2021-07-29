using System.Linq;

namespace RST.Command
{
    public class Fence : Unit,IUnit
    {
        public string Name
        {
            get
            {
                return "Fence";
            }
        }
        public override Action[] SupportedActions
        {
            get
            {
                return new Action[0];
            }
        }

    }
} 