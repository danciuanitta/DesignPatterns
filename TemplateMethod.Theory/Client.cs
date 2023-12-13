namespace TemplateMethod.Theory
{
    internal class Client
    {
        public void Operation()
        {
            AbstractClass templateToUse = new ConcreteClass1();

            templateToUse.TemplateMethod();
        }
    }
}
