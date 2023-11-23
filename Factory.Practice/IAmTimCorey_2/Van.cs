
namespace Factory.Practice.IAmTimCorey_2
{
    internal class Van: IVehicle
    {
        public string VehicleType { get; set; } = "van";

        public string Start()
        {
            return "the van started";
        }
    }
}
