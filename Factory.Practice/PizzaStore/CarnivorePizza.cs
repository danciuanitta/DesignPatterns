
namespace Factory.Practice.PizzaStore
{
    internal class CarnivorePizza : Pizza
    {
        internal override void Prepare()
        {
            Console.WriteLine("Prepare Pizza Carnivore");
        }
    }
}
