using Microsoft.Extensions.DependencyInjection;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.Employees;
using WarehouseManager.Service.WareHouses;

namespace WarehouseManager.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<WarehouseService>();
            return services;
        }
    }
}
