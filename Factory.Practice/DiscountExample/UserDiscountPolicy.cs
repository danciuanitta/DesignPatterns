
namespace Factory.Practice.DiscountExample
{
    internal class UserDiscountPolicy : DiscountPolicy
    {
        internal override Discount CreateDiscountType()
        {
            return new UserDiscount();
        }
    }
}
