namespace TemplateMethod.Theory
{
    internal class ConcreteClass2 : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("Primitive operation 1 from concrete class 2");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive operation 2 from concrete class 2");
        }
    }
}
