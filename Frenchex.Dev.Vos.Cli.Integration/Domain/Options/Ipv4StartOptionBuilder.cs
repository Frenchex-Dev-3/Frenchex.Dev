﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Options;

public interface IIpv4StartOptionBuilder
{
    Option<int> Build();
}

public class Ipv4StartOptionBuilder : IIpv4StartOptionBuilder
{
    public Option<int> Build()
    {
        return new Option<int>(new[] {"--ipv4-start"}, () => 2, "IPv4 start");
    }
}