
namespace Composite.Theory
{
    internal class Leaf : IComponent
    {
        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }

        public IComponent GetChild(int depth)
        {
            throw new NotImplementedException();
        }

        public void Operation()
        {
            Console.WriteLine("Operation from leaf");
        }

        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
