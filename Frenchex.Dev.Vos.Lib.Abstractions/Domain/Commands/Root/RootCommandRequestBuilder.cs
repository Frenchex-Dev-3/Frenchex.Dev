﻿namespace Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

public abstract class RootCommandRequestBuilder : IRootCommandRequestBuilder
{
    protected RootCommandRequestBuilder(
        IBaseRequestBuilderFactory baseRequestBuilderFactory
    )
    {
        BaseBuilder = baseRequestBuilderFactory.Factory(this);
    }

    public IBaseRequestBuilder BaseBuilder { get; }
}