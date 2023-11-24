
namespace AbstractFactory.Theory
{
    internal class Client
    {
        public Product CreateProduct()
        {
            ICreator creator = new Creator1();

            var part1 = creator.CreateProductA();
            var part2 = creator.CreateProductB();

            var product = new Product(part1, part2);

            return product;
        }
    }
}
