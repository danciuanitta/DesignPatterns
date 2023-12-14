
namespace State.Practice
{
    // Concrete state 1: DraftState
    public class DraftState : IInvoiceState
    {
        public void PrintStatus()
        {
            Console.WriteLine("Invoice is in Draft state.");
        }

        public void SubmitForApproval(Invoice invoice)
        {
            Console.WriteLine("Submitting invoice for approval...");
            // Transition to the next state
            invoice.SetState(new PendingState());
        }

        public void Approve(Invoice invoice)
        {
            Console.WriteLine("Cannot approve invoice in Draft state.");
        }

        public void Pay(Invoice invoice)
        {
            Console.WriteLine("Cannot pay invoice in Draft state.");
        }
    }
}
