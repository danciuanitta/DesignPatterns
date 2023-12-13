
namespace Flyweight.Theory
{
    internal class FlyweightFactory
    {
        private static Dictionary<string, IFlyweight> _flyweights = new();

        public FlyweightFactory()
        {
            _flyweights.Add("X", new ConcreteFlyweight());
            _flyweights.Add("Y", new ConcreteFlyweight());
            _flyweights.Add("Z", new ConcreteFlyweight());
        }

        public IFlyweight GetFlyweight(string key)
        {
            return _flyweights[key];
        }
    }
}
