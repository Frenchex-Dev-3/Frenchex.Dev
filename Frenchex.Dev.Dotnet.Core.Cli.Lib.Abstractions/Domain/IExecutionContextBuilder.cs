﻿namespace Frenchex.Dev.Dotnet.Core.Cli.Lib.Abstractions.Domain;

public interface IExecutionContextBuilder
{
    IExecutionContext Build();
}