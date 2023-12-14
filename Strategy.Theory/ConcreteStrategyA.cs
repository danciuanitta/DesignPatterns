
namespace Strategy.Theory
{
    internal class ConcreteStrategyA : IStrategy
    {
        public string PerformAlgorithm()
        {
            Console.WriteLine("Algorithm performed by ConcreteStrategyA");
            return "ConcreteStrategyA";
        }
    }
}
