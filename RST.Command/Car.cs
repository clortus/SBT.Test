using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RST.Command
{
    public class Car: Unit,IUnit
    {
        public string Name
        {
            get
            {
                return "Car";
            }
        }
        public override Action[] SupportedActions
        {
            get
            {
                return new[] {Action.Move};
            }
        }

    }
}
