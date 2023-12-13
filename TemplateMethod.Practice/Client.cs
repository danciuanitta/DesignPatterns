
namespace TemplateMethod.Practice
{
    internal class Client
    {
        public void Operation(decimal amount)
        {
            PaymentProcessorTemplate template = new DebitPaymentProcessor();

            template.ProcessPayment(amount);
        }
    }
}
