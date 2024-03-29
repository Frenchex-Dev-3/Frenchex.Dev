﻿using Frenchex.Dev.Dotnet.Core.Cli.Lib.Abstractions.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Frenchex.Dev.Dotnet.Core.Cli.Lib.Domain;

public class AppConfigurationConfiguration : IAppConfigurationConfiguration
{
    private readonly IEntrypointInfo _entrypointInfo;

    public AppConfigurationConfiguration(
        IEntrypointInfo entrypointInfo
    )
    {
        _entrypointInfo = entrypointInfo;
    }

    public void ConfigureApp(
        IContext context,
        HostBuilderContext hostContext,
        IConfigurationBuilder appConfiguration
    )
    {
        appConfiguration.SetBasePath(context.BasePath);
        appConfiguration.AddJsonFile(context.AppSettings, true);
        appConfiguration.AddJsonFile(
            $"appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json",
            true
        );

        appConfiguration.AddEnvironmentVariables(context.EnvVarPrefix);
        appConfiguration.AddCommandLine(_entrypointInfo.CommandLineArgs);
    }
}