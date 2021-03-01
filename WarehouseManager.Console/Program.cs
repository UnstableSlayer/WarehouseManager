using System;
using WarehouseManager.HttpClientHelper;
using Microsoft.Extensions.DependencyInjection;
using WarehouseManager.HttpClientHelper.AccountentTreeHttpServices;
using WarehouseManager.HttpClientHelper.AccountentTreeHttpServices.Commands;
using Microsoft.Extensions.Configuration;
using System.IO;
using Serilog;
using Microsoft.Extensions.Logging;

namespace Warehouse.ConsoleTest
{
    class Program
    {
        public static IConfiguration Configuration { get; set; }

        static void Main(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"appsettings.json", false, true)
                .Build();
            //Options x=new Options {URL= @"http://localhost:54255" };
            var seriLogging = new LoggerConfiguration()
                .WriteTo
                .File(@"log\log.txt")
                .CreateLogger();
            ServiceCollection services = new ServiceCollection();
            services.AddLogging(logger =>
            {
                logger.SetMinimumLevel(LogLevel.Debug);
                logger.AddSerilog(seriLogging);
            });

            services.AddSdkServices(o =>
            {
                o.URL = "http://localhost:54255";
            });
            services.AddSingleton<IConfiguration>(Configuration);
            Console.WriteLine(Configuration["ConfigDemo"]);
            var buildserviceprovider = services.BuildServiceProvider();
            var warehouseService = buildserviceprovider.GetService<AccountentTreeHttpService>();
            var warehouselist = warehouseService.GetAll().Result;
        }
    }
}
