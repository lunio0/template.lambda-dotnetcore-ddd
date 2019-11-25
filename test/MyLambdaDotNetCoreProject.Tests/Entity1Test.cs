using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using MyLambdaDotNetCoreProject.Api;
using MyLambdaDotNetCoreProject.Domain.AggregateModels.Entity1Aggregate;
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
    public class Entity1Test : IClassFixture<EnvironmentFixture>
    {
        public Entity1Test()
        {
            
        }
        [Fact]
        public async Task TestGetEntity()
        {
            // Invoke the lambda function and confirm the string was upper cased.
            var context = new TestLambdaContext();
            var response = await new Entity1Lambda().Get(new APIGatewayProxyRequest(), context);
            var entities = JsonConvert.DeserializeObject<IEnumerable<Entity1>>(response.Body);

            Assert.NotEmpty(entities);
        }
    }
}
