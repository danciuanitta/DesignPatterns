
namespace Bridge.Practice
{
    //concrete implementor

    internal class DebitPaymentType : IPaymentType
    {
        public void ProcessPaymentType()
        {
            Console.WriteLine("Processing flow for debits");
        }
    }
}
