using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Reflection;
using System.Linq;
using MyLambdaDotNetCoreProject.Domain.Aggregates.Entity1Aggregate;
using MyLambdaDotNetCoreProject.Infrastructure.Repositories;
using MyLambdaDotNetCoreProject.Application.Commands;
using System;
using MyLambdaDotNetCoreProject.Api.Infrastructure;

namespace MyLambdaDotNetCoreProject.Api
{
    class Startup
    {
        public static IServiceProvider BuildContainer()
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddEnvironmentVariables()
                                //template parameter used
                                .AddJsonFile($"appsettings.{System.Environment.GetEnvironmentVariable("appsetting")}.json")
                                .Build();

            var serviceCollection = new ServiceCollection()
                                    .AddModules(configuration)
                                    .AddRepositories()
                                    .AddQueries()
                                    ;
            
            return serviceCollection.BuildServiceProvider();
        }
    }
}
