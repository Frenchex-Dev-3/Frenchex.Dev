﻿using Frenchex.Dev.Dotnet.Wrapping.Lib.Domain.Commands.Root;

namespace Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Fix.Response;

public interface IFixCommandResponseBuilderFactory : IRootCommandResponseBuilderFactory
{
    IFixCommandResponseBuilder Factory();
}