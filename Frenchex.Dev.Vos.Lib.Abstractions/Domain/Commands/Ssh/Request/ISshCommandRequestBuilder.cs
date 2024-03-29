﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Ssh.Request;

public interface ISshCommandRequestBuilder : IRootCommandRequestBuilder
{
    ISshCommandRequest Build();
    ISshCommandRequestBuilder UsingNames(string[] namesOrId);
    ISshCommandRequestBuilder UsingCommands(string[] command);
    ISshCommandRequestBuilder WithPlain(bool with);
    ISshCommandRequestBuilder UsingExtraSshArgs(string extraSshArg);
}