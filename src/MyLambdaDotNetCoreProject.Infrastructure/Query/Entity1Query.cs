using MyLambdaDotNetCoreProject.Application.Query;
using MyLambdaDotNetCoreProject.Domain.AggregateModels.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Infrastructure.Query
{
    public class Entity1Query : IEntity1Query
    {
        IEnumerable<Entity1> IEntity1Query.GetAll() 
            => new Entity1[]
            {
                new Entity1("1"),
                new Entity1("2")
            };

        Entity1 IEntity1Query.GetOne(string id)
            => new Entity1("1");
    }
}
