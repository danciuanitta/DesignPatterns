
namespace Proxy.Practice.Payment
{
    //real subject
    internal class RealPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            // Actual payment processing logic goes here
            Console.WriteLine($"Processing payment of ${amount}");
        }
    }
}
