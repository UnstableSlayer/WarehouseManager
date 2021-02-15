using Microsoft.Extensions.DependencyInjection;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.Employees;
using WarehouseManager.Service.Products;
using WarehouseManager.Service.WareHouses;
using WarehouseManager.Service.AccountentTrees;

namespace WarehouseManager.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<EmployeeService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ProductService>();

            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<WarehouseService>();

            services.AddScoped<IAccountentTreeRepository, AccountentTreeRepository>();
            services.AddScoped<AccountentTreeService>();

            return services;
        }
    }
}
