using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Serialization.Json;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using MyLambdaDotNetCoreProject.Application.Query;


[assembly: LambdaSerializer(typeof(JsonSerializer))]
namespace MyLambdaDotNetCoreProject.Api
{
    public class Entity1Lambda
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Entity1Lambda() : this(Startup.BuildContainer().BuildServiceProvider())
        {
        }

        private Entity1Lambda(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [LambdaSerializer(typeof(JsonSerializer))]
        public async Task<APIGatewayProxyResponse> Get(APIGatewayProxyRequest request, ILambdaContext lambdaContext)
        {
            var mediator = _serviceProvider.GetService<IMediator>();

            var result = await mediator.Send(new GetEntity1Request());

            return result is null?
              new APIGatewayProxyResponse { StatusCode = 404 } 
              : new APIGatewayProxyResponse { StatusCode = 200, Body = Newtonsoft.Json.JsonConvert.SerializeObject(result) };
        }

        [LambdaSerializer(typeof(JsonSerializer))]
        public async Task<APIGatewayProxyResponse> GetById(APIGatewayProxyRequest request, ILambdaContext lambdaContext)
        {
            var mediator = _serviceProvider.GetService<IMediator>();

            string id = request.PathParameters["id"];
            var result = await mediator.Send(new GetEntity1Request(id));

            return result is null ?
              new APIGatewayProxyResponse { StatusCode = 404 }
              : new APIGatewayProxyResponse { StatusCode = 200, Body = Newtonsoft.Json.JsonConvert.SerializeObject(result) };
        }
    }
}
