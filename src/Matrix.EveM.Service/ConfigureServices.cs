using Matrix.EveM.Domain.Vendors.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Matrix.EveM.Service;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IVendorService, VendorService>();

        return services;
    }
}
