
namespace Prototype.Theory
{
    public class Client
    {
        private readonly IPrototype prototype;
        public Client(IPrototype prototype)
        {
            this.prototype = prototype;
        }
        public void SomeMethod()
        {
            IProduct product = new Product1() { SomeField = 1 };
            Console.WriteLine(product.SomeField);
            
            var newProduct = (Product1)prototype.Clone();
            Console.WriteLine(newProduct.SomeField);
        }
    }
}
