
namespace Factory.Practice.IAmTimCorey_2
{
    internal class VehicleFactory : IVehicleFactory
    {
        //using Func instead of IEnumerable, the actual creation of the (needed( IVehicle instance is deffered until the Create method is called.
        //With IEnumerable, you actually inject a list of instances, so they are all created at VehicleFactory object creation.
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
