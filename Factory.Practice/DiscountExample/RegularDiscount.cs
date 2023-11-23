
namespace Factory.Practice.DiscountExample
{
    internal class RegularDiscount : Discount
    {
        //this could be retrieved from config
        internal override decimal GetDiscountValue() => 0.05m;
    }
}
