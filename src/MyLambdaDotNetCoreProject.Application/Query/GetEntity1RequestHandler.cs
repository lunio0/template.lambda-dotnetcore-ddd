using MediatR;
using MyLambdaDotNetCoreProject.Domain.AggregateModels.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLambdaDotNetCoreProject.Application.Query
{
    public class GetEntity1RequestHandler : IRequestHandler<GetEntity1Request, IEnumerable<Entity1>>
    {
        readonly IEntity1Query _entity1Query;

        public GetEntity1RequestHandler(IEntity1Query entity1Query)
        {
            _entity1Query = entity1Query;
        }

        async Task<IEnumerable<Entity1>> IRequestHandler<GetEntity1Request, IEnumerable<Entity1>>.Handle(GetEntity1Request request, CancellationToken cancellationToken)
        {
            if (request.Id is null)
            {
                return this._entity1Query.GetAll();
            }
            else
            {
                Entity1 entity = this._entity1Query.GetOne(request.Id);

                return new Entity1[] { entity };
            }
        }
    }
}

