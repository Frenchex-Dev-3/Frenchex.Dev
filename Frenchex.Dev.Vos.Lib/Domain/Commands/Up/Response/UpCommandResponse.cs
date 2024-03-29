﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;
using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Up.Response;

namespace Frenchex.Dev.Vos.Lib.Domain.Commands.Up.Response;

public class UpCommandResponse : RootResponse, IUpCommandResponse
{
    public UpCommandResponse(
        Vagrant.Lib.Abstractions.Domain.Commands.Up.Response.IUpCommandResponse upCommandResponse
    )
    {
        Response = upCommandResponse;
    }

    public Vagrant.Lib.Abstractions.Domain.Commands.Up.Response.IUpCommandResponse Response { get; }
}