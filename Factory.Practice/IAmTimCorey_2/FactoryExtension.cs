using Microsoft.Extensions.DependencyInjection;

namespace Factory.Practice.IAmTimCorey_2
{
    public static class FactoryExtension
    {
        public static void AddVehicleFactory(this IServiceCollection services)
        {
            services.AddTransient<IVehicle, Car>();
            services.AddTransient<IVehicle, Van>();
            services.AddTransient<IVehicle, Truck>();
            services.AddSingleton<Func<IEnumerable<IVehicle>>>(x => () => x.GetService<IEnumerable<IVehicle>>()!);
            services.AddSingleton<IVehicleFactory, VehicleFactory>();
        }
    }
}
