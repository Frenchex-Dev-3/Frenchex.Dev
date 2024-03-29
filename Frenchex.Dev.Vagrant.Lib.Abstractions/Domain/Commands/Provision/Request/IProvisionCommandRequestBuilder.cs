﻿using Frenchex.Dev.Vagrant.Lib.Abstractions.Domain.Commands.Root.Request;

namespace Frenchex.Dev.Vagrant.Lib.Abstractions.Domain.Commands.Provision.Request;

public interface IProvisionCommandRequestBuilder : IRootCommandRequestBuilder
{
    IProvisionCommandRequest Build();
    IProvisionCommandRequestBuilder ProvisionWith(string[] with);
    IProvisionCommandRequestBuilder ProvisionVmName(string vmName);
}