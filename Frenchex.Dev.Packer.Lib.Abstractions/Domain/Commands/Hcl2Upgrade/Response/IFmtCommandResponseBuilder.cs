﻿using Frenchex.Dev.Dotnet.Wrapping.Lib.Domain.Commands.Root;

namespace Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Hcl2Upgrade.Response;

public interface IHcl2UpgradeCommandResponseBuilder : IRootCommandResponseBuilder
{
    IHcl2UpgradeCommandResponse Build();
}