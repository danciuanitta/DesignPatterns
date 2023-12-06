
namespace Builder.Theory
{
    internal interface IBuilder
    {
        Builder BuildPartA();
        Builder BuildPartB();
        ComplexObject Build();
    }
}
