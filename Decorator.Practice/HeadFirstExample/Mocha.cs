
namespace Decorator.Practice.HeadFirstExample
{
    internal class Mocha : CondimentDecorator
    {
        internal Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 0.2 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " " + "as Mocha";
        }
    }
}
