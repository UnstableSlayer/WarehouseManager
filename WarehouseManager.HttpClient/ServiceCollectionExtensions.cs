using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManager.HttpClientHelper.AccountentTreeHttpServices;
using WarehouseManager.HttpClientHelper.BrandHttpServices;

namespace WarehouseManager.HttpClientHelper
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSdkServices(this IServiceCollection services, Action<Options> options)
        {
            services.Configure(options);
            services.AddHttpClient("WarehouseClient");
            services.AddSingleton<HttpClientHelper>();
            services.AddScoped<AccountentTreeHttpService>();
            services.AddScoped<BrandService>();
            return services;
        }
    }
}
