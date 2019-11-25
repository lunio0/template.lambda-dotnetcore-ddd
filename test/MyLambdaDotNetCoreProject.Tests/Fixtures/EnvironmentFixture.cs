using Microsoft.Extensions.Configuration;
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
            using (var file = File.OpenText("environment.json"))
            {
                var jsonReader = new JsonTextReader(file);

                JObject.Load(jsonReader)
                    .GetValue("environmentVariables")
                    .Children()
                    .OfType<JProperty>()
                    .ToList()
                    .ForEach(//set environment variables
                        var => Environment.SetEnvironmentVariable(var.Name, var.Value.ToString())
                    );
            }
        }
    }
}
