using MyLambdaDotNetCoreProject.Application.Query.Readmodel;
using MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLambdaDotNetCoreProject.Application.Query
{
    public interface IEntity1Query
    {
        Task<IEnumerable<Entity1View>> GetAll();
        Task<Entity1View> GetOne(string id);
    }
}
