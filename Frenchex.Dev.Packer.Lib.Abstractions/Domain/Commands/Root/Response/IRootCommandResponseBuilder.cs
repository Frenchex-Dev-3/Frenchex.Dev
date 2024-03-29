﻿using Frenchex.Dev.Dotnet.Core.Process.Lib.Domain.Process;

namespace Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Root.Response;

public interface IRootCommandResponseBuilder
{
    IRootCommandResponseBuilder SetProcess(IProcess process);
    IRootCommandResponseBuilder SetProcessExecutionResult(ProcessExecutionResult processExecutionResult);
}