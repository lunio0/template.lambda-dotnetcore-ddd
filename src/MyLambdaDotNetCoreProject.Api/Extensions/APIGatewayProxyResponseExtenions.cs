using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLambdaDotNetCoreProject.Api.Extensions
{
    public static class APIGatewayProxyResponseExtenions
    {
        public static APIGatewayProxyResponse SetSuccess(this APIGatewayProxyResponse response, object body)
        {
            response.StatusCode = 200;
            response.Body = JsonConvert.SerializeObject(body);

            return response;
        }

        public static APIGatewayProxyResponse SetBadRequest(this APIGatewayProxyResponse response)
        {
            response.StatusCode = 404;

            return response;
        }

        public static APIGatewayProxyResponse SetNotfound(this APIGatewayProxyResponse response)
        {
            response.StatusCode = 404;

            return response;
        }

        public static APIGatewayProxyResponse SetInternalServerError(this APIGatewayProxyResponse response, string message)
        {
            response.StatusCode = 500;
            response.Body = message;

            return response;
        }
    }
}
