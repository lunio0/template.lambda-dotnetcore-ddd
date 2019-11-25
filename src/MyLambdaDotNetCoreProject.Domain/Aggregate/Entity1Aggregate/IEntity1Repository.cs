using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate
{
    public interface IEntity1Repository
    {
        void Create(Entity1 item);
        void Update(Entity1 item);
        Task<IEnumerable<Entity1>> RetrieveAsync();
        Task<Entity1> RetrieveAsync(string id);
    }
}
