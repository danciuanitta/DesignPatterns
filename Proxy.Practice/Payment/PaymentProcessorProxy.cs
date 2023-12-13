
namespace Proxy.Practice.Payment
{
    //proxy
    internal class PaymentProcessorProxy : IPaymentProcessor
    {
        private RealPaymentProcessor? realPaymentProcessor;

        public void ProcessPayment(double amount)
        {
            // Additional tasks before delegating to the real implementation
            Console.WriteLine("Proxy: Performing security checks before processing payment.");

            // Lazy initialization of the real payment processor
            if (realPaymentProcessor == null)
            {
                realPaymentProcessor = new RealPaymentProcessor();
            }

            // Delegating the actual payment processing to the real implementation
            realPaymentProcessor.ProcessPayment(amount);

            // Additional tasks after delegating to the real implementation
            Console.WriteLine("Proxy: Logging payment transaction.");
        }
    }
}
