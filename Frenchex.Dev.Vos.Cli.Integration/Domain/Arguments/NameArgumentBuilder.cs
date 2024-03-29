﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Arguments;

public interface INameArgumentBuilder
{
    Argument<string> Build();
}

public class NameArgumentBuilder : INameArgumentBuilder

{
    public Argument<string> Build()
    {
        return new Argument<string>("name", "Name");
    }
}