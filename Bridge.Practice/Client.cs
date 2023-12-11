
namespace Bridge.Practice
{
    internal class Client
    {
        public void ProcessPayment()
        {
            IPaymentType paymentType = new CreditPaymentType();
            IPaymentProcessor paymentProcessor = new BamboraPaymentProcessor(paymentType);

            paymentProcessor.ProcessPayment();
        }
    }
}
