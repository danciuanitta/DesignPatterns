namespace Factory.Practice.DiscountExample
{
    internal class Order
    {
        private readonly decimal _netAmount;
        public decimal Amount => OrderDiscountPolicy.Apply(_netAmount);
        public DiscountPolicy OrderDiscountPolicy
        {
            get;
            private set;
        }

        public Order(decimal amount, DiscountPolicy discountPolicy)
        {
            _netAmount= amount;
            OrderDiscountPolicy = discountPolicy;
        }
    }
}
