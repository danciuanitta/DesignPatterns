
namespace Factory.Practice.PizzaStore
{
    internal class Client
    {
        //how to do this in DI or in ctor

        public void OrderPizza(string city, string type)
        {
            PizzaStore? pizzaStore = null;
            if (city.Equals("New York"))
            {
                pizzaStore = new NYStylePizzaStore();
            }
            else
            {
                pizzaStore = new ChicagoStylePizzaStore();
            }

            pizzaStore.PreparePizza(type);
        }
    }
}
