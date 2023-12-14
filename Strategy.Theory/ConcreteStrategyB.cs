
namespace Strategy.Theory
{
    internal class ConcreteStrategyB : IStrategy
    {
        public string PerformAlgorithm()
        {
            Console.WriteLine("Algorithm performed by ConcreteStrategyB");
            return "ConcreteStrategyB";
        }
    }
}
