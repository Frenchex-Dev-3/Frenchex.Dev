﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Up.Response;

public interface IUpCommandResponse : IRootCommandResponse
{
    Vagrant.Lib.Abstractions.Domain.Commands.Up.Response.IUpCommandResponse Response { get; }
}