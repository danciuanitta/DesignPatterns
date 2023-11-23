
namespace Factory.Practice.PizzaStore
{
    internal class VeggiePizza : Pizza
    {
        internal override void Prepare()
        {
            Console.WriteLine("Prepare Pizza Veggie");
        }
    }
}
