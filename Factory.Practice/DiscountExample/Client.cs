namespace Factory.Practice.DiscountExample
{
    internal class Client
    {
        public void CreateOrder()
        {
            //again an if else or something to decide on factory
            var order = new Order(1000, new UserDiscountPolicy());
            Console.WriteLine(order.Amount);
        }
    }
}
