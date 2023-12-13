
namespace TemplateMethod.Practice
{
    internal abstract class PaymentProcessorTemplate
    {
        public void ProcessPayment(decimal amount)
        {
            RebalanceInternalLedger(amount);

            SendSettlementMessage(amount);

            SendPaymentConfirmation(amount);
        }

        protected abstract void SendSettlementMessage(decimal amount);
        protected abstract void SendPaymentConfirmation(decimal amount);
        protected abstract void RebalanceInternalLedger(decimal amount);
    }
}
