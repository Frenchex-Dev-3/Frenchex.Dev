﻿using Frenchex.Dev.Dotnet.Wrapping.Lib.Domain.Commands.Root;

namespace Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Fix.Response;

public interface IFixCommandResponseBuilder : IRootCommandResponseBuilder
{
    IFixCommandResponse Build();
}