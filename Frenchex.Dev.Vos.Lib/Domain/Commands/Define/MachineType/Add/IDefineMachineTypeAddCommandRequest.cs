﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Definitions;
using Frenchex.Dev.Vos.Lib.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Domain.Commands.Define.MachineType.Add;

public interface IDefineMachineTypeAddCommandRequest : IRootCommandRequest
{
    MachineTypeDefinitionDeclaration DefinitionDeclaration { get; }
}