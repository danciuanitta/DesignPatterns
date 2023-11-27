
namespace Bridge.Theory
{
    internal class Client
    {
        public void SomeOperation()
        {
            //you decide the actual implementation and run time, using some conditions (this could also happen in startup depending on some configuration value loaded or env used)
            IImplementor implementor = new Implementor1();
            IAbstraction abstraction = new Abstraction1(implementor);

            var result = abstraction.Operation();

            Console.WriteLine($"result is {result}");
        }
    }
}
