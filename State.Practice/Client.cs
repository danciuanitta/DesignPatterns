
namespace State.Practice
{
    internal class Client
    {
        public void Operation()
        {
            // Create an invoice
            var invoice = new Invoice();

            // Print initial status
            invoice.PrintStatus();

            // Submit for approval
            invoice.SubmitForApproval();
            invoice.PrintStatus();

            // Approve
            invoice.Approve();
            invoice.PrintStatus();

            // Pay
            invoice.Pay();
            invoice.PrintStatus();
        }
    }
}
