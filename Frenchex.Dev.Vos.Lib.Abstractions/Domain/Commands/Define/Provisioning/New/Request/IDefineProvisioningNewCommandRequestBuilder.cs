﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Define.Provisioning.New.Request;

public interface IDefineProvisioningNewCommandRequestBuilder : IRootCommandRequestBuilder
{
    IDefineProvisioningNewCommandRequest Build();
}