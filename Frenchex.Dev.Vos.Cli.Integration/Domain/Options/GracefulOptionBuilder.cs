﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Options;

public interface IGracefulOptionBuilder
{
    Option<bool> Build();
}

public class GracefulOptionBuilder : IGracefulOptionBuilder
{
    public Option<bool> Build()
    {
        return new Option<bool>(new[] {"--graceful", "-g"}, "Graceful");
    }
}