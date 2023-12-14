
namespace State.Practice
{
    // Context class representing the billing process
    public class Invoice
    {
        private IInvoiceState _state;

        public Invoice()
        {
            // Initialize with the default state
            _state = new DraftState();
        }

        public void SetState(IInvoiceState state)
        {
            _state = state;
        }

        public void PrintStatus()
        {
            _state.PrintStatus();
        }

        public void SubmitForApproval()
        {
            _state.SubmitForApproval(this);
        }

        public void Approve()
        {
            _state.Approve(this);
        }

        public void Pay()
        {
            _state.Pay(this);
        }
    }
}
