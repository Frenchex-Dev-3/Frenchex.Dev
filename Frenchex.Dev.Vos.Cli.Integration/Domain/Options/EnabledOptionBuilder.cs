﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Options;

public interface IEnabledOptionBuilder
{
    Option<bool> Build();
}

public class EnabledOptionBuilder : IEnabledOptionBuilder
{
    public Option<bool> Build()
    {
        return new Option<bool>(new[] {"--enabled", "-e"}, "Enabled");
    }
}