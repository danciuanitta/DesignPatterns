
namespace Composite.Theory
{
    internal class Composite : IComponent
    {
        private readonly List<IComponent> components = new();

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public IComponent GetChild(int depth)
        {
            return components[depth];
        }

        public void Operation()
        {
            foreach (var child in components)
            {
                Console.WriteLine($"depth is {components.IndexOf(child)}");
                child.Operation();
            }
        }

        public void Remove(IComponent component)
        {
            components.Remove(component);
        }
    }
}
