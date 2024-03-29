﻿using System.Text;
using Frenchex.Dev.Dotnet.Core.Filesystem.Lib.Domain;
using Frenchex.Dev.Dotnet.Core.Process.Lib.Domain.ProcessBuilder;
using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Build.Command;
using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Build.Request;
using Frenchex.Dev.Packer.Lib.Abstractions.Domain.Commands.Build.Response;
using Frenchex.Dev.Packer.Lib.Domain.Commands.Root.Command;
using Microsoft.Extensions.Configuration;

namespace Frenchex.Dev.Packer.Lib.Domain.Commands.Build.Command;

public class BuildCommand : RootCommand, IBuildCommand
{
    private readonly IBuildCommandResponseBuilderFactory _buildCommandResponseBuilderFactory;

    public BuildCommand(
        IProcessBuilder processBuilder,
        IFilesystem fileSystem,
        IConfiguration configuration,
        IBuildCommandResponseBuilderFactory buildCommandResponseBuilderFactory
    ) : base(
        processBuilder,
        fileSystem,
        configuration)
    {
        _buildCommandResponseBuilderFactory = buildCommandResponseBuilderFactory;
    }

    public string GetCliCommandName()
    {
        return "build";
    }

    public IBuildCommandResponse StartProcess(IBuildCommandRequest request)
    {
        var responseBuilder = _buildCommandResponseBuilderFactory.Factory();

        BuildAndStartProcess(
            request,
            responseBuilder,
            BuildArguments(request)
        );

        return responseBuilder.Build();
    }

    private string BuildArguments(IBuildCommandRequest request) => GetCliCommandName() + " " + BuildPackerOptions(request) + " " + BuildPackerArguments(request);

    private string BuildPackerArguments(IBuildCommandRequest request) => "";

    private string BuildPackerOptions(IBuildCommandRequest request)
    {
        if (null == request.Base) throw new InvalidOperationException("request.base is null");

        return new StringBuilder()
                .Append(request.Color.HasValue && request.Color.Value ? " -color" : "")
                .Append(request.Debug.HasValue && request.Debug.Value ? " -debug" : "")
                .Append(request.Except != null && request.Except.Any() ? " -except" + String.Join(",", request.Except) : "")
                .Append(request.Only != null && request.Only.Any() ? " -only" + String.Join(",", request.Only) : "")
                .Append(request.Force.HasValue && request.Force.Value ? "-force" : "")
                .Append(request.MachineReadable.HasValue && request.MachineReadable.Value ? "-machine-readable" : "")
                .Append(request.OnError.HasValue ? OnErrorEnumToString(request.OnError.Value) : "")
                .Append(BuildRootPackerOptions(request.Base))
                .ToString()
            ;
    }
    
    private string OnErrorEnumToString(OnErrorEnum inputEnumValue){
        switch(inputEnumValue)
        {
            case OnErrorEnum.Abort: return "abort";
            case OnErrorEnum.Ask: return "ask";
            case OnErrorEnum.Cleanup: return "cleanup";
            case OnErrorEnum.RunCleanupProvisioner: return "run-cleanup-provisioner";
            default: return "";
        }
    }
}