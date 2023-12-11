namespace Decorator.Practice.HeadFirstExample
{
    internal abstract class Beverage
    {
        protected string Description = "Description";
        public string GetDescription()
        {
            return Description;
        }
        public abstract double Cost();
    }
}
