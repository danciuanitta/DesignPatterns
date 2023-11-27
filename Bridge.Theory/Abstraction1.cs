
namespace Bridge.Theory
{
    internal class Abstraction1 : IAbstraction
    {
        private readonly IImplementor implementor;

        public Abstraction1(IImplementor implementor)
        {
            this.implementor = implementor;
        }

        public string Operation()
        {
            return implementor.SomeOperation();
        }
    }
}
