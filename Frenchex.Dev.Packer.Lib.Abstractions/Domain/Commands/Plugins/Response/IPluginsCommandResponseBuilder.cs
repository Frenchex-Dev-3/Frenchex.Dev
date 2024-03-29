﻿using Frenchex.Dev.Dotnet.Wrapping.Lib.Domain.Commands.Root;

namespace Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Plugins.Response;

public interface IPluginsCommandResponseBuilder : IRootCommandResponseBuilder
{
    IPluginsCommandResponse Build();
}