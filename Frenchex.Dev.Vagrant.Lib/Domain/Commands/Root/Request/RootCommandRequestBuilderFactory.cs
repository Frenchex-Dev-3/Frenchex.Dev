﻿using Frenchex.Dev.Vagrant.Lib.Abstractions.Domain.Commands.Root.Base.Request;
using Frenchex.Dev.Vagrant.Lib.Abstractions.Domain.Commands.Root.Request;

namespace Frenchex.Dev.Vagrant.Lib.Domain.Commands.Root.Request;

public abstract class RootCommandRequestBuilderFactory : IRootCommandRequestBuilderFactory
{
    protected readonly IBaseCommandRequestBuilderFactory BaseRequestBuilderFactory;

    protected RootCommandRequestBuilderFactory(
        IBaseCommandRequestBuilderFactory baseRequestBuilderFactory
    )
    {
        BaseRequestBuilderFactory = baseRequestBuilderFactory;
    }
}