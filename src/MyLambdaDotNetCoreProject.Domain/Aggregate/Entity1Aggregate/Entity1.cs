using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate
{
    public class Entity1
    {
        public Entity1(string name)
        {
            Name = name;
        }

        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public string Name { get; private set; }
    }
}
