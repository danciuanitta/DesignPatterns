
namespace TemplateMethod.Theory
{
    internal abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("Start algorithm.");
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("End of algorithm");
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
    }
}
