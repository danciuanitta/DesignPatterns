﻿using Microsoft.Extensions.DependencyInjection;

namespace Factory.Practice.IAmTimCorey
{
    //https://www.youtube.com/watch?v=2PXAfSfvRKY&t=2662s
    internal static class AbstractFactoryExtension
    {
        public static void AddAbstractFactory<TInterface, TImplementation>(this IServiceCollection services)
            where TInterface : class
            where TImplementation : class, TInterface
        {
            services.AddTransient<TInterface, TImplementation>();
            services.AddSingleton<Func<TInterface>>(x=> () =>x.GetService<TInterface>()!);
            services.AddSingleton<IAbstractFactory<TInterface>, AbstractFactory<TInterface>>();
        }
    }
}
