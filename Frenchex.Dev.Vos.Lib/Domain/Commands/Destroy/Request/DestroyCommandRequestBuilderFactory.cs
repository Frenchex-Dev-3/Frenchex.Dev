﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Destroy.Request;
using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Domain.Commands.Destroy.Request;

public class DestroyCommandRequestBuilderFactory : RootCommandRequestBuilderFactory,
    IDestroyCommandRequestBuilderFactory
{
    public DestroyCommandRequestBuilderFactory(IBaseRequestBuilderFactory baseRequestBuilderFactory) : base(
        baseRequestBuilderFactory)
    {
    }

    public IDestroyCommandRequestBuilder Factory()
    {
        return new DestroyCommandRequestBuilder(BaseRequestBuilderFactory);
    }
}