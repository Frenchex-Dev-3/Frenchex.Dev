﻿using System.CommandLine;

namespace Frenchex.Dev.Vos.Cli.Integration.Domain.Options;

public interface IWorkingDirectoryOptionBuilder
{
    Option<string> Build();
}

public class WorkingDirectoryOptionBuilder : IWorkingDirectoryOptionBuilder
{
    public Option<string> Build()
    {
        return new Option<string>(
            new[] {"--working-directory", "-w"},
            Directory.GetCurrentDirectory,
            "Working Directory"
        );
    }
}