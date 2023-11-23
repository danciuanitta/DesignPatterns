
namespace Factory.Practice.PizzaStore
{
    internal abstract class PizzaStore
    {
        public void PreparePizza(string type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
        }

        internal abstract Pizza CreatePizza(string type);
    }
}
