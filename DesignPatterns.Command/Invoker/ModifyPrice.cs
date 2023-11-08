using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Invoker
{
    public class ModifyPrice
    {
        private List<ICommand> _commands;
        private ICommand _command;

        public ModifyPrice()
        {
            _commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command) => _command = command;

        public void Invoke()
        {
            _commands.Add(_command);
            _command.Execute();
        }

        public void Undo()
        {
            foreach (var command in Enumerable.Reverse(_commands))
            {
                command.Undo();
            }
        }
    }
}
