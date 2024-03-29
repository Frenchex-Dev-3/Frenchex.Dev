﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;
using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Status.Request;

namespace Frenchex.Dev.Vos.Lib.Domain.Commands.Status.Request;

public class StatusCommandRequestBuilderFactory : RootCommandRequestBuilderFactory, IStatusCommandRequestBuilderFactory
{
    public StatusCommandRequestBuilderFactory(IBaseRequestBuilderFactory baseRequestBuilderFactory) : base(
        baseRequestBuilderFactory)
    {
    }

    public IStatusCommandRequestBuilder Factory()
    {
        return new StatusCommandRequestBuilder(BaseRequestBuilderFactory);
    }
}