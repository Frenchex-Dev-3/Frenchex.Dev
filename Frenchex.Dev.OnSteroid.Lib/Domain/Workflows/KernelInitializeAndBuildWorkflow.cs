﻿using Frenchex.Dev.OnSteroid.Lib.Domain.Kernel;
using Microsoft.Extensions.DependencyInjection;

namespace Frenchex.Dev.OnSteroid.Lib.Domain.Workflows;

public class KernelInitializeAndBuildWorkflow : IKernelInitializeAndBuildWorkflow
{
    private readonly IKernelBuilderBuildingContextFactory _kernelBuilderBuildingContextFactory;
    private IKernelBuilderBuildingContext? _cachedKernelBuilderBuildingContext;
    
    public KernelInitializeAndBuildWorkflow(
        IKernelBuilderBuildingContextFactory kernelBuilderBuildingContextFactory
    )
    {
        _kernelBuilderBuildingContextFactory = kernelBuilderBuildingContextFactory;
    }

    public async Task<IKernel> FlowAsync(IKernerlConfiguration kernelConfiguration)
    {
        return await Task.Run(async () =>
        {
            _cachedKernelBuilderBuildingContext ??= await Initialize(kernelConfiguration);
            var kernel = _cachedKernelBuilderBuildingContext.Build();

            return kernel;
        });
    }

    public async Task<IKernelBuilderBuildingContext> Initialize(IKernerlConfiguration kernelConfiguration)
    {
        return await Task.Run(() =>
            _kernelBuilderBuildingContextFactory.Build(new ServiceCollection(), kernelConfiguration));
    }

    public async Task<IKernel> Build(IKernelBuilderBuildingContext kernelBuilderBuildingContext)
    {
        return await Task.Run(kernelBuilderBuildingContext.Build);
    }
}