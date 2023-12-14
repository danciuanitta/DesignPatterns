
namespace ChainOfResponsibility.Practice.PaymentExample
{
    public interface IPaymentHandler
    {
        void SetHandler(IPaymentHandler handler);
        void ProcessPayment(PaymentRequest request);
    }
}
