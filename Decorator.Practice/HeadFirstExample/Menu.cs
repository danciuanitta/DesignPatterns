namespace Decorator.Practice.HeadFirstExample
{
    internal class Menu
    {
        public void Order()
        {
            Beverage beverage = new Espresso();
            CondimentDecorator decorator = new Mocha(beverage);

            Console.WriteLine($"You ordered: {decorator.GetDescription} and it will cost{decorator.Cost()}");
        }
    }
}
