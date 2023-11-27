
namespace Adapter.Theory
{
    internal class Client
    {
        public void SomeOperation()
        {
            ITarget target = new ObjectAdapter(new Adaptee());
            var firstOperationResult = target.Operation();
            Console.WriteLine(firstOperationResult);

            ITarget secondType = new ClassAdapter();
            var secondOperationResult = secondType.Operation();
            Console.WriteLine(secondOperationResult);
        }
    }
}
