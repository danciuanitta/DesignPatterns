
namespace Factory.Practice.DiscountExample
{
    internal abstract class DiscountPolicy
    {
        internal abstract Discount CreateDiscountType();

        public decimal Apply(decimal amount)
        {
            var discount = CreateDiscountType();
            return amount * (1 - discount.GetDiscountValue());
        }
    }
}
