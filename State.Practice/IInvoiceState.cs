
namespace State.Practice
{
    // State interface
    public interface IInvoiceState
    {
        void PrintStatus();
        void SubmitForApproval(Invoice invoice);
        void Approve(Invoice invoice);
        void Pay(Invoice invoice);
    }
}
