// See https://aka.ms/new-console-template for more information
using Mediator.Practice;
using Mediator.Practice.WithMediatR;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prototype.Theory;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<Prototype.Theory.Client>();
builder.Services.AddTransient<IPrototype, Product1>();
builder.Services.AddTransient<IProduct, Product1>();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining(typeof(MediatRClient));
});
builder.Services.AddSingleton<UserRegistrar>();
builder.Services.AddScoped<ChatMessageHandler>();

using IHost host = builder.Build();

//ExemplifyPrototypePattern(host.Services);
//ExemplifyMediatorPattern();
ExemplifyMediatorPatternWithMediatR(host.Services);

static void ExemplifyPrototypePattern(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    Prototype.Theory.Client client = provider.GetRequiredService<Prototype.Theory.Client>();

    client.SomeMethod();

    Console.ReadLine();
}

static void ExemplifyMediatorPattern()
{
    MediatorClient client = new MediatorClient();
    client.ChatFunctionality();

    Console.ReadLine();
}

static void ExemplifyMediatorPatternWithMediatR(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    var mediator = provider.GetRequiredService<IMediator>();
    var handler = provider.GetRequiredService<ChatMessageHandler>();
    var registrar = provider.GetRequiredService<UserRegistrar>();

    var client = new MediatRClient(registrar, mediator);

    client.ChatFunctionality();

    Console.ReadLine();
}

await host.RunAsync();