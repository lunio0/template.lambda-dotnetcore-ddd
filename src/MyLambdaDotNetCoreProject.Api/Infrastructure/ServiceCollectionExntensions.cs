using AutoMapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyLambdaDotNetCoreProject.Application.Commands;
using MyLambdaDotNetCoreProject.Application.Queries;
using MyLambdaDotNetCoreProject.Domain.Aggregates.Entity1Aggregate;
using MyLambdaDotNetCoreProject.Infrastructure.Queries;
using MyLambdaDotNetCoreProject.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLambdaDotNetCoreProject.Api.Infrastructure
{
    public static class ServiceCollectionExntensions
    {
        readonly static Assembly apiAssembly = typeof(Startup).Assembly;
        readonly static Assembly applicationAssembly = typeof(CreateEntity1CommandHandler).Assembly;
        readonly static Assembly domainAssembly = typeof(Entity1).Assembly;
        readonly static Assembly infrastructureAssembly = typeof(Entity1Repository).Assembly;

        public static IServiceCollection AddModules(this IServiceCollection services, IConfigurationRoot configurationRoot)
        {
            return services
                .AddMediatR(applicationAssembly)
                .AddAutoMapper(apiAssembly);
        }
        
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IEntity1Repository, Entity1Repository>();
        }

        public static IServiceCollection AddQueries(this IServiceCollection services)
        {
            return services
                .AddScoped<IEntity1Query, Entity1Query>();
        }
    }
}
