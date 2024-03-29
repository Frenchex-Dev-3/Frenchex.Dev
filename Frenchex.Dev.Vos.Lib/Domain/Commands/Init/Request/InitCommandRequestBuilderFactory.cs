﻿using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Init.Request;
using Frenchex.Dev.Vos.Lib.Abstractions.Domain.Commands.Root;

namespace Frenchex.Dev.Vos.Lib.Domain.Commands.Init.Request;

public class InitCommandRequestBuilderFactory : RootCommandRequestBuilderFactory, IInitCommandRequestBuilderFactory
{
    public InitCommandRequestBuilderFactory(IBaseRequestBuilderFactory baseRequestBuilderFactory) : base(
        baseRequestBuilderFactory)
    {
    }

    public IInitCommandRequestBuilder Factory()
    {
        return new InitCommandRequestBuilder(BaseRequestBuilderFactory);
    }
}