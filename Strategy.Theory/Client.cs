
namespace Strategy.Theory
{
    internal class Client
    {
        public void Operation()
        {
            IStrategy chosenStrategy = new ConcreteStrategyA();
            Context contextObject = new Context(chosenStrategy);

            contextObject.Operation();
        }
    }
}
