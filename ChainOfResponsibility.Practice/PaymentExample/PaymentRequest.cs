

namespace ChainOfResponsibility.Practice.PaymentExample
{
    // Request class representing a payment request
    public class PaymentRequest
    {
        public string? PaymentMethod { get; set; }
        public decimal Amount { get; set; }
    }
}
