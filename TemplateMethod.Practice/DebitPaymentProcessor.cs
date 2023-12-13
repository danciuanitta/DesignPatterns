using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Practice
{
    internal class DebitPaymentProcessor : PaymentProcessorTemplate
    {
        protected override void RebalanceInternalLedger(decimal amount)
        {
            throw new NotImplementedException();
        }

        protected override void SendPaymentConfirmation(decimal amount)
        {
            throw new NotImplementedException();
        }

        protected override void SendSettlementMessage(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
