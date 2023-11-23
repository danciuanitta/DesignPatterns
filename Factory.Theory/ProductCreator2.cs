namespace Factory.Theory
{
    internal class ProductCreator2 : Creator
    {
        public override Product Create()
        {
            return new Product2();
        }
    }
}
