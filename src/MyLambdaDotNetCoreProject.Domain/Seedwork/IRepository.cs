using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Domain.Seedwork
{
    public interface IRepository<T> where T: IAggregate
    { }
}
