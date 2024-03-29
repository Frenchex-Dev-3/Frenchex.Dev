﻿using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Fix.Response;
using Microsoft.Extensions.DependencyInjection;

namespace Frenchex.Dev.Packer.Lib.Domain.Commands.Fix.Response;

public class FixCommandResponseBuilderFactory : IFixCommandResponseBuilderFactory
{
    private readonly IServiceProvider _serviceProvider;

    public FixCommandResponseBuilderFactory(
        IServiceProvider serviceProvider
    )
    {
        _serviceProvider = serviceProvider;
    }

    public IFixCommandResponseBuilder Factory()
    {
        return _serviceProvider.GetRequiredService<IFixCommandResponseBuilder>();
    }
}