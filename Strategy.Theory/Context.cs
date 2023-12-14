
namespace Strategy.Theory
{
    internal class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Operation()
        {
            Console.WriteLine("Starting choosing algorithm");
            var result = _strategy.PerformAlgorithm();

            Console.WriteLine($"The result of algorithm is {result}");
        }
    }
}
