﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Define.Provisioning.Map.Response;

public interface IDefineProvisioningMapCommandResponseBuilder : IRootResponseBuilder
{
    IDefineProvisioningMapCommandResponse Build();
}