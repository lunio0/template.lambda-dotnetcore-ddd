using MyLambdaDotNetCoreProject.Application.Queries.Readmodel;
using MyLambdaDotNetCoreProject.Domain.Aggregates.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLambdaDotNetCoreProject.Application.Queries
{
    public interface IEntity1Query
    {
        Task<IEnumerable<Entity1View>> GetAll();
        Task<Entity1View> GetOne(string id);
    }
}
