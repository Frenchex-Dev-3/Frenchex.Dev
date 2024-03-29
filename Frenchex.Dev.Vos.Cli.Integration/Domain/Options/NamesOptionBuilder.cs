﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Options;

public interface INamesOptionBuilder
{
    Option<string[]> Build();
}

public class NamesOptionBuilder : INamesOptionBuilder
{
    public Option<string[]> Build()
    {
        return new Option<string[]>("--name", "Name or ID");
    }
}