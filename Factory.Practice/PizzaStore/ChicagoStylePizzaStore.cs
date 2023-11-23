
namespace Factory.Practice.PizzaStore
{
    internal class ChicagoStylePizzaStore : PizzaStore
    {
        internal override Pizza CreatePizza(string type)
        {
            if (type.Equals("carnivore"))
                return new CarnivorePizza();
            else if (type.Equals("veggie"))
                return new VeggiePizza();
            else
                throw new NotImplementedException("No such pizza in Chicago");
        }
    }
}
