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
    #region Mysql (nuget package : Pomelo.EntityFrameworkCore.MySql)

    //public class MysqlDbContext : DbContext
    //{
    //    public MysqlDbContext(DbContextOptions options) : base(options)
    //    {
    //    }

    //    public DbSet<Entity1> Entity1s { get; set; }

    //    public class MysqlDbContextDbContextFactory : IDesignTimeDbContextFactory<MysqlDbContext>
    //    {
    //        public MysqlDbContext CreateDbContext(string[] args)
    //        {
    //            var optionsBuilder = new DbContextOptionsBuilder<MysqlDbContext>();

    //            var configuration = new ConfigurationBuilder()
    //                            .AddJsonFile($"appsettings.Local.json")
    //                            //.AddJsonFile($"appsettings.Production.json")
    //                            .Build();

    //            optionsBuilder.UseMySql(configuration.GetConnectionString("MysqlConnectionString"));

    //            return new MysqlDbContext(optionsBuilder.Options);
    //        }
    //    }
    //}

    #endregion
}