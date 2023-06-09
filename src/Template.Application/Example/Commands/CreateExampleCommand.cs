﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Application.Mediator.Requests;
using Template.Application.Mediator.Responses;

namespace Template.Application.Example.Commands;
public class CreateExampleCommand :  IApplicationRequest<ApplicationResponse<CreateExampleCommandResponse>>
{
    public string Name { get; init; } = default!;
}
