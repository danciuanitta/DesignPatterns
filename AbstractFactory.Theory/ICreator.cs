
namespace AbstractFactory.Theory
{
    internal interface ICreator
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}
