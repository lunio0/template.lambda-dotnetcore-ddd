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
using MyLambdaDotNetCoreProject.Application.Queries;
using MyLambdaDotNetCoreProject.Application.Queries.Readmodel;

[assembly: LambdaSerializer(typeof(JsonSerializer))]
namespace MyLambdaDotNetCoreProject.Api
{
    public class Entity1Lambda
    {
        private readonly IEntity1Query _entity1Query;
        private readonly IMediator _mediator;

        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Entity1Lambda() : this(Startup.BuildContainer())
        {
        }

        private Entity1Lambda(IServiceProvider serviceProvider)
        {
            this._mediator = serviceProvider.GetRequiredService<IMediator>();
            this._entity1Query = serviceProvider.GetRequiredService<IEntity1Query>();
        }

        [LambdaSerializer(typeof(JsonSerializer))]
        public async Task<APIGatewayProxyResponse> Get(APIGatewayProxyRequest request, ILambdaContext lambdaContext)
        {
            IEnumerable<Entity1View> result = await this._entity1Query.GetAll().ConfigureAwait(false);

            return result is null?
              new APIGatewayProxyResponse { StatusCode = 404 } 
              : new APIGatewayProxyResponse { StatusCode = 200, Body = Newtonsoft.Json.JsonConvert.SerializeObject(result) };
        }

        [LambdaSerializer(typeof(JsonSerializer))]
        public async Task<APIGatewayProxyResponse> GetById(APIGatewayProxyRequest request, ILambdaContext lambdaContext)
        {
            string id = request.PathParameters["id"];
            Entity1View result = await this._entity1Query.GetOne(id).ConfigureAwait(false);

            return result is null ?
              new APIGatewayProxyResponse { StatusCode = 404 }
              : new APIGatewayProxyResponse { StatusCode = 200, Body = Newtonsoft.Json.JsonConvert.SerializeObject(result) };
        }
    }
}
