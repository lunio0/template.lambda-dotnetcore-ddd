using AutoMapper;
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
