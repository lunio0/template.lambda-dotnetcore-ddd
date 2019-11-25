using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyLambdaDotNetCoreProject.Domain.Aggregates.Entity1Aggregate;

namespace MyLambdaDotNetCoreProject.Infrastructure.Ef
{
    #region postgreSQL (nuget package : Npgsql.EntityFrameworkCore.PostgreSQL)

    //public class PostgreSqlDbContext : DbContext
    //{
    //    public PostgreSqlDbContext(DbContextOptions options) : base(options)
    //    {
    //    }

    //    public DbSet<Entity1> Entity1s { get; set; }

    //    public class PostgreSqlDbContextFactory : IDesignTimeDbContextFactory<PostgreSqlDbContext>
    //    {
    //        public PostgreSqlDbContext CreateDbContext(string[] args)
    //        {
    //            var optionsBuilder = new DbContextOptionsBuilder<PostgreSqlDbContext>();

    //            var configuration = new ConfigurationBuilder()
    //                            .AddJsonFile($"appsettings.Local.json")
    //                            //.AddJsonFile($"appsettings.Production.json")
    //                            .Build();

    //            optionsBuilder.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnectionString"));

    //            return new PostgreSqlDbContext(optionsBuilder.Options);
    //        }
    //    }
    //}

    #endregion
}