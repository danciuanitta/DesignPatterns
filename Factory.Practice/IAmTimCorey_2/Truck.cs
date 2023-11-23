
namespace Factory.Practice.IAmTimCorey_2
{
    internal class Truck : IVehicle
    {
        public string VehicleType { get; set; } = "truck";

        public string Start()
        {
            return "the truck started";
        }
    }
}
