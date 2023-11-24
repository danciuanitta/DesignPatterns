
namespace AbstractFactory.Theory
{
    internal class Product
    {
        public Product(IProductA productA, IProductB productB)
        {
            ProductA = productA;
            ProductB = productB;
        }

        public IProductA ProductA { get; set; }
        public IProductB ProductB { get; set; }
    }
}
