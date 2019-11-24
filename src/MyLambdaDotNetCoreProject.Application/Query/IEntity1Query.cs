using MyLambdaDotNetCoreProject.Domain.AggregateModels.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Application.Query
{
    public interface IEntity1Query
    {
        IEnumerable<Entity1> GetAll();
        Entity1 GetOne(string id);
    }
}
