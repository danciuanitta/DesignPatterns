
namespace Builder.Theory
{
    internal interface IBuilder
    {
        Builder BuildPartA(ProductA1 productA1);
        Builder BuildPartB(ProductA2 productA2);
        ComplexObject Build();
    }
}
