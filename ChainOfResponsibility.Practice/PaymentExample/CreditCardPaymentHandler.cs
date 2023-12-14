namespace ChainOfResponsibility.Practice.PaymentExample
{
    // Concrete handler 1: CreditCardPaymentHandler
    public class CreditCardPaymentHandler : IPaymentHandler
    {
        private IPaymentHandler _handler;

        public void SetHandler(IPaymentHandler handler)
        {
            _handler = handler;
        }

        private readonly decimal creditCardLimit = 5000;

        public void ProcessPayment(PaymentRequest request)
        {
            if (request.PaymentMethod.Equals("CreditCard", StringComparison.OrdinalIgnoreCase) && request.Amount <= creditCardLimit)
            {
                Console.WriteLine($"Payment of ${request.Amount} processed using Credit Card.");
            }
            else
            {
                Console.WriteLine($"Credit Card payment cannot be processed. Passing to the next handler.");
                _handler.ProcessPayment(request);
            }
        }
    }
}
