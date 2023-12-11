namespace Bridge.Practice
{
    //refined abstraction
    internal class WorldpayPaymentProcessor : IPaymentProcessor
    {
        private readonly IPaymentType paymentType;

        public WorldpayPaymentProcessor(IPaymentType paymentType)
        {
            this.paymentType = paymentType;
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Setup to process payment using Worlday and proceed using the correct payment type");
            paymentType.ProcessPaymentType();
        }
    }
}
