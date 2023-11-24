namespace Builder.Theory
{
    internal class Director
    {
        private readonly IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public ComplexObject SomeMethod()
        {
            var firstPart = new ProductA1();
            var secondPart = new ProductA2();

            var output = builder.BuildPartA(firstPart).BuildPartB(secondPart).Build();

            return output;
        }
    }
}
