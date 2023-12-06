namespace Builder.Theory
{
    internal class Director
    {
        private readonly IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public ComplexObject Construct()
        {
            //GoF: for all objects in structure => builder->BuildPart()
            var output = builder.BuildPartA().BuildPartB().Build();

            return output;
        }
    }
}
