﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Define.Machine.Add.Request;
using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Define.Machine.Add.Response;
using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Define.Machine.Add.Command;

public interface
    IDefineMachineAddCommand : IAsyncCommand,
        IAsyncRootCommand<IDefineMachineAddCommandRequest, IDefineMachineAddCommandResponse>
{
}