
namespace Factory.Theory
{
    //ny style pizza store
    internal class ProductCreator1 : ICreator
    {
        public IProduct Create()
        {
            //could have some conditions here and return different concrete products (but a different set than in the other concrete creator
            return new Product1();
        }
    }
}
