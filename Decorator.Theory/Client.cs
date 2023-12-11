namespace Decorator.Theory
{
    internal class Client
    {
        internal void Operation()
        {
            IComponent initialObject = new ConcreteComponent();
            IComponent component = new ConcreteDecoratorA(initialObject);

            component.Operation();
        }
    }
}
