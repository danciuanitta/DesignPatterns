
namespace Decorator.Theory
{
    internal class ConcreteDecoratorA : IDecorator, IComponent
    {
        private readonly IComponent component;

        public ConcreteDecoratorA(IComponent component)
        {
            this.component = component;
        }

        public void Operation()
        {
            Console.WriteLine("Hello from decorator.");
            component.Operation();
        }
    }
}
