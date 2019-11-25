using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Application.Commands
{
    public class CreateEntity1Command : IRequest<string>
    {
        public string Name { get; set; }
    }
}
