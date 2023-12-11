
namespace Bridge.Practice
{
    //refined abstraction
    internal class BamboraPaymentProcessor : IPaymentProcessor
    {
        private readonly IPaymentType paymentType;

        public BamboraPaymentProcessor(IPaymentType paymentType)
        {
            this.paymentType = paymentType;
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Setup to process payment using Bambora and proceed using the correct payment type");
            paymentType.ProcessPaymentType();
        }
    }
}
