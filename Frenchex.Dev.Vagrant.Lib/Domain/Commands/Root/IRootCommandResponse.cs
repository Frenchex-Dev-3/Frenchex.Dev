﻿using Frenchex.Dev.Dotnet.Core.Process.Lib.Domain.Process;

namespace Frenchex.Dev.Vagrant.Lib.Domain.Commands.Root;

public interface IRootCommandResponse
{
    IProcess Process { get; }
    ProcessExecutionResult ProcessExecutionResult { get; }
}