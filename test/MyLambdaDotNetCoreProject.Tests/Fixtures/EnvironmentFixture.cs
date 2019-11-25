using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyLambdaDotNetCoreProject.Tests
{
    /// <summary>
    /// shared for tests within test classes
    /// <see: href="https://xunit.net/docs/shared-context"></href>
    /// </summary>
    public class EnvironmentFixture 
    {
        public EnvironmentFixture()
        {
            using (var file = File.OpenText("testSettings.json"))
            {
                var reader = new JsonTextReader(file);
                var jo = JObject.Load(reader);

                var environmentVariables = jo
                    .GetValue("environmentVariables")
                    .Children()
                    .OfType<JProperty>()
                    .Select(o => new {
                        Name = o.Name,
                        Value = o.Value.ToString()
                    });

                foreach (var variable in environmentVariables)
                {
                    Environment.SetEnvironmentVariable(variable.Name, variable.Value);
                }
            }
        }
    }
}
