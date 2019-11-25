using AutoMapper;
using MyLambdaDotNetCoreProject.Application.Queries.Readmodel;
using MyLambdaDotNetCoreProject.Domain.Aggregates.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Api.Infrastructure.Automapper.CommandToRead
{
    public class Entity1Profile: Profile
    {
        public Entity1Profile()
        {
            CreateMap<Entity1, Entity1View>();
        }
    }
}
