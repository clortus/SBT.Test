using System.Collections.Generic;
using System.Linq;

namespace RST.Command
{
    public interface IUnit
    {
        string Name{ get; }

        Action[] SupportedActions{ get; }

        bool IsCommandExecuted(ICommand command);
    }

    //абстрактный класс нужен, чтобы не повторять код метода IsCommandExecuted
    public abstract class Unit
    {
        public abstract Action[] SupportedActions{ get; }
        
        public bool IsCommandExecuted(ICommand command)
        {
            return SupportedActions.Any(a => a == command.Action);
        }
    }

}