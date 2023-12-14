
namespace Command.Theory
{
    internal class ConcreteCommand : ICommand
    {
        private readonly Receiver _receiver;
        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;   
        }

        public void Execute()
        {
            Console.WriteLine("Command execute");
            _receiver.Action();
        }
    }
}
