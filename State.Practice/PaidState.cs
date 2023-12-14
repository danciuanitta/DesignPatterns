
namespace State.Practice
{
    // Concrete state 3: PaidState
    public class PaidState : IInvoiceState
    {
        public void PrintStatus()
        {
            Console.WriteLine("Invoice is in Paid state.");
        }

        public void SubmitForApproval(Invoice invoice)
        {
            Console.WriteLine("Cannot submit paid invoice for approval.");
        }

        public void Approve(Invoice invoice)
        {
            Console.WriteLine("Cannot approve paid invoice.");
        }

        public void Pay(Invoice invoice)
        {
            Console.WriteLine("Invoice is already paid.");
        }
    }
}
