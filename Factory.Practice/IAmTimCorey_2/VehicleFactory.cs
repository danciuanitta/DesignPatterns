
namespace Factory.Practice.IAmTimCorey_2
{
    internal class VehicleFactory : IVehicleFactory
    {
        private readonly Func<IEnumerable<IVehicle>> factory;
        public VehicleFactory(Func<IEnumerable<IVehicle>> factory)
        {
            this.factory = factory;
        }

        public IVehicle Create(string name)
        {
            var set = factory();
            IVehicle output = set.First(x => x.VehicleType == name);

            return output;
        }
    }
}
