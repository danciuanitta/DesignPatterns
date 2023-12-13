namespace TemplateMethod.Theory
{
    internal sealed class ConcreteClass1 : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("Primitive operation 1 from concrete class 1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive operation 2 from concrete class 1");
        }
    }
}
