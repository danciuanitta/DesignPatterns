namespace Factory.Theory
{
    internal class ProductCreator2 : ICreator
    {
        public IProduct Create()
        {
            return new Product2();
        }
    }
}
