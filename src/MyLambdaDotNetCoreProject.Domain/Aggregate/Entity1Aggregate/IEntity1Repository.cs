using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate
{
    public interface IEntity1Repository
    {
        void Create(Entity1 item);
        void Update(Entity1 item);
        IEnumerable<Entity1> Retrieve();
        Entity1 Retrieve(string id);
    }
}
