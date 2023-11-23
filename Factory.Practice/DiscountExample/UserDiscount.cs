
namespace Factory.Practice.DiscountExample
{
    internal class UserDiscount : Discount
    {
        //this could be an api call to get user settings
        internal override decimal GetDiscountValue() => 0.1m;
    }
}
