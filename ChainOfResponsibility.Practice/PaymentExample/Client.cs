
namespace ChainOfResponsibility.Practice.PaymentExample
{
    internal class Client
    {
        public void Operation()
        {
            // Creating payment handlers
            var creditCardHandler = new CreditCardPaymentHandler();
            var payPalHandler = new PayPalPaymentHandler();

            // Setting up the chain
            creditCardHandler.SetHandler(payPalHandler);

            // Making payment requests
            var request1 = new PaymentRequest { PaymentMethod = "CreditCard", Amount = 3000 };
            var request2 = new PaymentRequest { PaymentMethod = "PayPal", Amount = 1000 };
            var request3 = new PaymentRequest { PaymentMethod = "BankTransfer", Amount = 2000 };

            // Processing payment requests
            creditCardHandler.ProcessPayment(request1);
            creditCardHandler.ProcessPayment(request2);
            creditCardHandler.ProcessPayment(request3);
        }
    }
}
