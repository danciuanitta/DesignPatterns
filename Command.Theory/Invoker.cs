
namespace Command.Theory
{
    internal class Invoker
    {
        private ICommand _command;
        internal void StoreCommand(ICommand command)
        {
            Console.WriteLine("Command stored");
            _command = command;
        }
        
        internal void Operation()
        {
            Console.WriteLine("Invoke execute command");
            _command.Execute();
        }
    }
}
