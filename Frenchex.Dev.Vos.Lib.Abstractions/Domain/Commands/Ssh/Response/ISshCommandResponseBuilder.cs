﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Ssh.Response;

public interface ISshCommandResponseBuilder : IRootResponseBuilder
{
    ISshCommandResponse Build();
}