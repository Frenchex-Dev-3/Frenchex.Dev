﻿using Frenchex.Dev.Vos.Lib.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Domain.Commands.SshConfig;

public interface ISshConfigCommand : IRootCommand<ISshConfigCommandRequest, ISshConfigCommandResponse>
{
}