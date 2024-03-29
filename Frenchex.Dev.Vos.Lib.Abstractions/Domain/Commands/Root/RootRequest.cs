﻿namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

public class RootRequest : IRootCommandRequest
{
    public RootRequest(IBaseRequest @base)
    {
        Base = @base;
    }

    public IBaseRequest Base { get; }
}