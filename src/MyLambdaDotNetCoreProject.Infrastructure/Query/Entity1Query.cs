using MyLambdaDotNetCoreProject.Application.Query;
using MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Infrastructure.Query
{
    public class Entity1Query : IEntity1Query
    {
        readonly IEntity1Repository _entity1Repository;

        public Entity1Query(IEntity1Repository entity1Repository)
        {
            this._entity1Repository = entity1Repository;
        }

        IEnumerable<Entity1> IEntity1Query.GetAll() => this._entity1Repository.Retrieve();

        Entity1 IEntity1Query.GetOne(string id) => this._entity1Repository.Retrieve(id);
    }
}
