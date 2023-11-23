
namespace Factory.Practice.PizzaStore
{
    internal class NYStylePizzaStore : PizzaStore
    {
        internal override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new CheesePizza();
            else if (type.Equals("veggie"))
                return new VeggiePizza();
            else
                throw new NotImplementedException("No such pizza in NY");
        }
    }
}
