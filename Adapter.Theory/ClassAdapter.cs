
namespace Adapter.Theory
{
    internal class ClassAdapter : Adaptee, ITarget
    {
        public string Operation()
        {
            return SpecificOperation();
        }
    }
}
