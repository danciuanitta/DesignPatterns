
namespace State.Practice
{
    // Concrete state 2: PendingState
    public class PendingState : IInvoiceState
    {
        public void PrintStatus()
        {
            Console.WriteLine("Invoice is in Pending state.");
        }

        public void SubmitForApproval(Invoice invoice)
        {
            Console.WriteLine("Invoice is already submitted for approval.");
        }

        public void Approve(Invoice invoice)
        {
            Console.WriteLine("Approving invoice...");
            // Transition to the next state
            invoice.SetState(new PaidState());
        }

        public void Pay(Invoice invoice)
        {
            Console.WriteLine("Cannot pay invoice in Pending state.");
        }
    }

}
