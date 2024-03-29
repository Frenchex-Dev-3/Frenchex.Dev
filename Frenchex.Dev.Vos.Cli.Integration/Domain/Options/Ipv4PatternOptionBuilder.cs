﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Options;

public interface IIpv4PatternOptionBuilder
{
    Option<string> Build();
}

public class Ipv4PatternOptionBuilder : IIpv4PatternOptionBuilder
{
    public Option<string> Build()
    {
        return new Option<string>(
            new[] {"--ipv4-pattern"},
            () => "10.100.1.#INSTANCE#",
            "IPv4 pattern"
        );
    }
}