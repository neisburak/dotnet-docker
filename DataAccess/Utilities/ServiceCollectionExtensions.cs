using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Utilities;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, Action<Options> options)
    {
        var model = new Options();
        options(model);

        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(model.ConnectionString);
        });

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductFeatureRepository, ProductFeatureRepository>();

        return services;
    }
}