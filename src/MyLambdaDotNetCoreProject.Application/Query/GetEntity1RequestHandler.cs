using MediatR;
using MyLambdaDotNetCoreProject.Application.Query.Readmodel;
using MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLambdaDotNetCoreProject.Application.Query
{
    public class GetEntity1RequestHandler : IRequestHandler<GetEntity1Request, IEnumerable<Entity1View>>
    {
        readonly IEntity1Query _entity1Query;

        public GetEntity1RequestHandler(IEntity1Query entity1Query)
        {
            _entity1Query = entity1Query;
        }

        public async Task<IEnumerable<Entity1View>> Handle(GetEntity1Request request, CancellationToken cancellationToken)
        {
            if (request.Id is null)
            {
                return await this._entity1Query.GetAll();
            }
            else
            {
                Entity1View entity = await this._entity1Query.GetOne(request.Id);

                return new Entity1View[] { entity };
            }
        }
    }
}

