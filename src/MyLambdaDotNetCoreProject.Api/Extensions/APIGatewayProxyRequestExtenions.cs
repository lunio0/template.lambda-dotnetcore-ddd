using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLambdaDotNetCoreProject.Api.Extensions
{
    public static class APIGatewayProxyRequestExtenions
    {
        public static T DeserializeBody<T>(this APIGatewayProxyRequest request) where T : class
            
            => JsonConvert.DeserializeObject<T>(request?.Body, JsonNonPublicSettingProvider.Provide());
    }

    class JsonNonPublicSettingProvider
    {
        public static JsonSerializerSettings Provide() => new JsonSerializerSettings() { ContractResolver = new Resolver() };

        class Resolver : DefaultContractResolver
        {
            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                var prop = base.CreateProperty(member, memberSerialization);
                if (member is PropertyInfo pi)
                {
                    prop.Readable = (pi.GetMethod != null);
                    prop.Writable = (pi.SetMethod != null);
                }
                return prop;
            }
        }
    }
}
