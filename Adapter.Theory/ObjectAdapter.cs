
namespace Adapter.Theory
{
    internal class ObjectAdapter : ITarget
    {
        private readonly IAdaptee adaptee;
        public ObjectAdapter(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public string Operation()
        {
            return adaptee.SpecificOperation();
        }
    }
}
