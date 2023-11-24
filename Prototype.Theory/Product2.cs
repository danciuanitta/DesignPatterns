namespace Prototype.Theory
{
    public class Product2 : IProduct, IPrototype
    {
        public int SomeField { get; set; }
        public IProduct Clone()
        {
            return (Product2)this.MemberwiseClone();
        }
    }
}
