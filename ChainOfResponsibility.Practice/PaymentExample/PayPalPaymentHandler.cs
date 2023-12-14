
namespace ChainOfResponsibility.Practice.PaymentExample
{
    // Concrete handler 2: PayPalPaymentHandler
    public class PayPalPaymentHandler : IPaymentHandler
    {
        private IPaymentHandler _handler;

        public void SetHandler(IPaymentHandler handler)
        {
            _handler = handler;
        }

        public void ProcessPayment(PaymentRequest request)
        {
            if (request.PaymentMethod.Equals("PayPal", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Payment of ${request.Amount} processed using PayPal.");
            }
            else
            {
                Console.WriteLine($"PayPal payment cannot be processed. Passing to the next handler.");
                _handler.ProcessPayment(request);
            }
        }
    }
}
