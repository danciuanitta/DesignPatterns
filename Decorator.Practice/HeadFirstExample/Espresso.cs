
namespace Decorator.Practice.HeadFirstExample
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double Cost()
        {
            return 1.2;
        }
    }
}
