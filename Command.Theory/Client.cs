
namespace Command.Theory
{
    internal class Client
    {
        public void Operation()
        {
            Receiver receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.StoreCommand(command);

            Task.Delay(5);

            invoker.Operation();
        }
    }
}
