
namespace Factory.Practice.DiscountExample
{
    internal class RegularDiscountPolicy : DiscountPolicy
    {
        internal override Discount CreateDiscountType()
        {
            return new RegularDiscount();
        }
    }
}
