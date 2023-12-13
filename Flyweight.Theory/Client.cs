
namespace Flyweight.Theory
{
    internal class Client
    {
        public void Operation()
        {
            FlyweightFactory factory = new FlyweightFactory();
            // Work with different flyweight instances
            IFlyweight firstFlyweight = factory.GetFlyweight("X");
            firstFlyweight.Operation("Extrinsic State of the Flyweight X");

            IFlyweight secondFlyweight = factory.GetFlyweight("Y");
            secondFlyweight.Operation("Extrinsic State of the Flyweight Y");

            IFlyweight thirdFlyweight = factory.GetFlyweight("X");
            thirdFlyweight.Operation("Extrinsic State of the Flyweight XNEW");
        }
    }
}
