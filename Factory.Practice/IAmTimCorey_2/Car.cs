namespace Factory.Practice.IAmTimCorey_2
{
    internal class Car : IVehicle
    {
        public string VehicleType { get; set; } = "car";

        public string Start()
        {
            return "the car started";
        }
    }
}
