using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using MediatR;
using MyLambdaDotNetCoreProject.Application.Query;
using MyLambdaDotNetCoreProject.Infrastructure.Query;

namespace MyLambdaDotNetCoreProject.Api
{
    class Startup
    {
        public static IServiceCollection BuildContainer()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddEnvironmentVariables()
              //template parameter used
              .AddJsonFile($"appsettings.{System.Environment.GetEnvironmentVariable("appsetting")}.json")
              .Build();

            return ConfigureServices(configuration);
        }

        //dependency injection and other application service configurations
        private static IServiceCollection ConfigureServices(IConfigurationRoot configurationRoot)
        {
            var services = new ServiceCollection();

            services
              .AddMediatR(typeof(GetEntity1RequestHandler).Assembly)
              .AddScoped<IEntity1Query,Entity1Query>()
              ;
              //.AddTransient(typeof(IAwsClientFactory<>), typeof(AwsClientFactory<>))
              //.AddTransient<IItemRepository, ItemDynamoRepository>()
            return services;
        }
    }
}
