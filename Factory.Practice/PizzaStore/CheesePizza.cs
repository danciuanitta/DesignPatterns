
namespace Factory.Practice.PizzaStore
{
    internal class CheesePizza : Pizza
    {
        internal override void Prepare()
        {
            Console.WriteLine("Prepare Pizza Cheese");
        }
    }
}
