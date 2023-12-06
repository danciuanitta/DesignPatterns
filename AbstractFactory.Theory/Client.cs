
namespace AbstractFactory.Theory
{
    internal class Client
    {
        public void SomeOperation()
        {
            ICreator creator = new Creator1();

            var part1 = creator.CreateProductA();
            var part2 = creator.CreateProductB();
        }
    }
}
