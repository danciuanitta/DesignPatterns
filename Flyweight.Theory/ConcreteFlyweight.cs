
namespace Flyweight.Theory
{
    internal class ConcreteFlyweight : IFlyweight
    {
        public string? ExtrinsicState { get; set; }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine(" ConcreteFlyweight: " + extrinsicState);
        }
    }
}
