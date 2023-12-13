
namespace Proxy.Practice.Payment
{
    internal class Client
    {
        public void Operation()
        {
            // Using the real payment processor directly
            Console.WriteLine("Using RealPaymentProcessor directly:");
            var realProcessor = new RealPaymentProcessor();
            realProcessor.ProcessPayment(100.0);

            Console.WriteLine();

            // Using the payment processor proxy
            Console.WriteLine("Using PaymentProcessorProxy:");
            var paymentProxy = new PaymentProcessorProxy();
            paymentProxy.ProcessPayment(150.0);
        }
    }
}
