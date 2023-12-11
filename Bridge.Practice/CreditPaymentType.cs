
namespace Bridge.Practice
{
    //concrete implementor
    internal class CreditPaymentType : IPaymentType
    {
        public void ProcessPaymentType()
        {
            Console.WriteLine("Processing flow for credit cards");
        }
    }
}
