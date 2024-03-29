﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Options;

public interface IPrimaryOptionBuilder
{
    Option<bool> Build();
}

public class PrimaryOptionBuilder : IPrimaryOptionBuilder
{
    public Option<bool> Build()
    {
        return new Option<bool>(new[] {"--primary"}, "Primary");
    }
}