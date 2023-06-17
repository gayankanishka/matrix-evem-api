using Matrix.EveM.Dal.Repositories;
using Matrix.EveM.Domain.Vendors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Matrix.EveM.Dal;

public static class ConfigureServices
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        
        services.AddScoped<IVendorRepository, VendorRepository>();

        return services;
    }
}
