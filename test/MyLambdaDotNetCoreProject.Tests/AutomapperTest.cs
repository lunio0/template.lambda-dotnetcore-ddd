using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using AutoMapper;
using MyLambdaDotNetCoreProject.Api;
using MyLambdaDotNetCoreProject.Domain.Aggregates.Entity1Aggregate;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace MyLambdaDotNetCoreProject.Tests
{
    public class AutomapperTest : IClassFixture<EnvironmentFixture>
    {
        [Fact]
        public void TestProfiles()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Api.Infrastructure.Automapper.CommandToRead.Entity1Profile());
            });

            config.AssertConfigurationIsValid();
        }
    }
}
