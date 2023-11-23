
namespace Factory.Practice.IAmTimCorey_2
{
    internal class Client
    {
        private readonly IVehicleFactory factory;
        public Client(IVehicleFactory factory)
        {
            this.factory = factory;
        }

        public void SomeMethod()
        {
            var vehicle = factory.Create("truck");
            vehicle.Start();
        }
    }
}
