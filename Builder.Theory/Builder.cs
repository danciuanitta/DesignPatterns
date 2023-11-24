

namespace Builder.Theory
{
    //this is the 'fluent' implementation of the Builder pattern, but you could also just do a simple implementation, without chaining all methods
    //with simple implementation, you would have some AddPartA, AddPartB methods, with void return type
    //you could also have a reset of the object, once it was built
    internal class Builder : IBuilder
    {
        private readonly ComplexObject _object;
        public Builder()
        {
            _object = new ComplexObject();
        }

        public Builder BuildPartA( ProductA1 productA1)
        {
            _object.ProductA1 = productA1;
            return this;
        }

        public Builder BuildPartB(ProductA2 productA2)
        {
            _object.ProductA2 = productA2;
            return this;
        }

        public ComplexObject Build()
        {
            return _object;
        }
    }
}
