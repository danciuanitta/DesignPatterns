
namespace Prototype.Theory
{
    public class Product1 : IProduct, IPrototype
    {
        public int SomeField { get; set; }
        public IProduct Clone()
        {
            //return new Product1
            //{
            //    SomeField = this.SomeField
            //};

            //creates a shallow copy of current object
            return (Product1)this.MemberwiseClone();

            // If your object has reference types fields, you might need to implement deep cloning to avoid shared references in your cloned objects
        }
    }
}
