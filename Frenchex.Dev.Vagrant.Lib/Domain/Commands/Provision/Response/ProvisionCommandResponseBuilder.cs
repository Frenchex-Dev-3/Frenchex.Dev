﻿using Frenchex.Dev.Vagrant.Lib.Abstractions.Domain.Commands.Provision.Response;
using Frenchex.Dev.Vagrant.Lib.Domain.Commands.Root.Response;

namespace Frenchex.Dev.Vagrant.Lib.Domain.Commands.Provision.Response;

public class ProvisionCommandResponseBuilder : RootResponseBuilder, IProvisionCommandResponseBuilder
{
    public IProvisionCommandResponse Build()
    {
        if (null == Process || null == ProcessExecutionResult)
            throw new InvalidOperationException("process or execution result is null");

        return new ProvisionCommandResponse(Process, ProcessExecutionResult);
    }
}