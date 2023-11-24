
namespace Factory.Practice.IAmTimCorey_2
{
    internal class VehicleFactory : IVehicleFactory
    {
        private readonly Func<IEnumerable<IVehicle>> factory;
        //private readonly IEnumerable<IVehicle> services;

        public VehicleFactory(Func<IEnumerable<IVehicle>> factory)//, IEnumerable<IVehicle> services)
        {
            this.factory = factory;
            //this.services = services;
        }

        public IVehicle Create(string name)
        {
            //var instance = services.First(x => x.VehicleType == name);
            var set = factory();
            IVehicle output = set.First(x => x.VehicleType == name);

            return output;
        }
    }
}
