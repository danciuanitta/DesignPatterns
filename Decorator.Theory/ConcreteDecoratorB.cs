
namespace Decorator.Theory
{
    internal class ConcreteDecoratorB : IDecorator, IComponent
    {
        private readonly IComponent component;

        public ConcreteDecoratorB(IComponent component)
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