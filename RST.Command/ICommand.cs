using System;
using System.Linq;

namespace RST.Command
{
    public interface ICommand
    {
        string Name { get; }
        Action Action { get; }
        CommandExecutionResult Execute(IUnit unit);

    }
    /// <summary>Вид «действия»</summary>
    public enum Action
    {
        /// <summary>Двигаться</summary>
        Move,
        /// <summary>Огонь</summary>
        Fire,
    }

    public class MoveCommand : ICommand
    {
        public string Name
        {
            get
            {
                return Action.ToString();
            }
        }
        public Action Action
        {
            get
            {
                return Action.Move;
            }
        }
        public CommandExecutionResult Execute(IUnit unit)
        {
            return new CommandExecutionResult(this, unit);
        }
    }

    public class FireCommand : ICommand
    {
        public string Name
        {
            get
            {
                return Action.ToString();
            }
        }
        public Action Action
        {
            get
            {
                return Action.Fire;
            }
        }
        public CommandExecutionResult Execute(IUnit unit)
        {
            return new CommandExecutionResult(this, unit);
        }

    }



    /// <summary>Результат выполнения команды</summary>
    public class CommandExecutionResult
    {

        public string ExecutedCommandString(ICommand command, IUnit unit)
        {
            return String.Format("Команда {0} выполнена для юнита {1}", command.Name, unit.Name);
        }

        public CommandExecutionResult(ICommand command, IUnit unit)
        {
            //проверка выполнения команды юнитом
            if (IsCommandExecuted(command, unit))
                Console.WriteLine(ExecutedCommandString(command, unit));
        }

        /// <summary>
        /// Тут можно проверить, выполнена команда или нет.
        /// </summary>
        public bool IsCommandExecuted(ICommand command, IUnit unit)
        {
            return unit.IsCommandExecuted(command);
        }
    }
}