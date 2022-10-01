﻿using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Hcl2Upgrade.Command;
using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Hcl2Upgrade.Facade;
using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Hcl2Upgrade.Request;
using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Hcl2Upgrade.Response;
using Frenchex.Dev.Packer.Lib.Domain.Commands.Hcl2Upgrade.Command;
using Frenchex.Dev.Packer.Lib.Domain.Commands.Hcl2Upgrade.Facade;
using Frenchex.Dev.Packer.Lib.Domain.Commands.Hcl2Upgrade.Request;
using Microsoft.Extensions.DependencyInjection;

namespace Frenchex.Dev.Packer.Lib.Domain.Commands.Hcl2Upgrade.DependencyInjection;

public static class ServicesConfiguration
{
    public static void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection
            .AddScoped<IHcl2UpgradeCommand, Hcl2UpgradeCommand>()
            .AddScoped<IHcl2UpgradeCommandFacade, Hcl2UpgradeCommandFacade>()
            .AddScoped<IHcl2UpgradeCommandRequestBuilder, Hcl2UpgradeCommandRequestBuilder>()
            .AddScoped<IHcl2UpgradeCommandRequestBuilderFactory, Hcl2UpgradeCommandRequestBuilderFactory>()
            .AddScoped<IHcl2UpgradeCommandResponseBuilder, IHcl2UpgradeCommandResponseBuilder>()
            .AddScoped<IHcl2UpgradeCommandResponseBuilderFactory, IHcl2UpgradeCommandResponseBuilderFactory>()
            ;
    }
}