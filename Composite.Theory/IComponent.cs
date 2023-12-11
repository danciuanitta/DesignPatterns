
namespace Composite.Theory
{
    internal interface IComponent
    {
        void Operation();
        void Add(IComponent component);
        void Remove(IComponent component);
        IComponent GetChild(int depth);
    }
}
