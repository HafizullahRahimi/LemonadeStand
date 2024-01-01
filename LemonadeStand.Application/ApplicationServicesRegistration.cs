
using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LemonadeStand.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IFruitPressService, FruitPressService>();

        }
    }
}
