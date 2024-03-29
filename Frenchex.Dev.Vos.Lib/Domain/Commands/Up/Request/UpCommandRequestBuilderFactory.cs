﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;
using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Up.Request;

namespace Frenchex.Dev.Vos.Lib.Domain.Commands.Up.Request;

public class UpCommandRequestBuilderFactory : RootCommandRequestBuilderFactory, IUpCommandRequestBuilderFactory
{
    public UpCommandRequestBuilderFactory(IBaseRequestBuilderFactory baseRequestBuilderFactory) : base(
        baseRequestBuilderFactory)
    {
    }

    public IUpCommandRequestBuilder Factory()
    {
        return new UpCommandRequestBuilder(BaseRequestBuilderFactory);
    }
}