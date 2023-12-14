
namespace ChainOfResponsibility.Theory
{
    internal class Client
    {
        public void Operation()
        {
            IHandler firstHandler = new ConcreteHandlerA();
            IHandler secondHandler = new ConcreteHandlerB();

            firstHandler.SetTheNextHandler(secondHandler);

            firstHandler.Process("ConcreteHandlerA");

            //should have validation and default logic for the case no handler found
        }
    }
}
