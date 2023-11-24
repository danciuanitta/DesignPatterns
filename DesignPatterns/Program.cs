// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prototype.Theory;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<Prototype.Theory.Client>();
builder.Services.AddTransient<IPrototype, Product1>();
builder.Services.AddTransient<IProduct, Product1>();

using IHost host = builder.Build();

ExemplifyPrototypePattern(host.Services);

static void ExemplifyPrototypePattern(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    Prototype.Theory.Client client = provider.GetRequiredService<Prototype.Theory.Client>();

    client.SomeMethod();

    Console.ReadLine();
}

await host.RunAsync();