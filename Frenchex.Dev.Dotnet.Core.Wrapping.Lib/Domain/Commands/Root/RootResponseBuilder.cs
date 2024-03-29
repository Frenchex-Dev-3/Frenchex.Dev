﻿using Frenchex.Dev.Dotnet.Core.Process.Lib.Domain.Process;

namespace Frenchex.Dev.Dotnet.Wrapping.Lib.Domain.Commands.Root;

public abstract class RootResponseBuilder : IRootCommandResponseBuilder
{
    protected IProcess? Process;
    protected ProcessExecutionResult? ProcessExecutionResult;

    public IRootCommandResponseBuilder SetProcess(IProcess process)
    {
        Process = process;
        return this;
    }

    public IRootCommandResponseBuilder SetProcessExecutionResult(ProcessExecutionResult processExecutionResult)
    {
        ProcessExecutionResult = processExecutionResult;
        return this;
    }
}