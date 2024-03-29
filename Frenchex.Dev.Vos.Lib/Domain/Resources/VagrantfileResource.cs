﻿using System.Reflection;
using Frenchex.Dev.Dotnet.Core.Filesystem.Lib.Domain;

namespace Frenchex.Dev.Vos.Lib.Domain.Resources;

public interface IVagrantfileResource
{
    void Copy(string? destination);
}

public class VagrantfileResource : IVagrantfileResource
{
    private const string Vagrantfile = "Vagrantfile";
    private readonly IFilesystem _filesystem;
    private readonly string _sourceVagrantfile;

    public VagrantfileResource(IFilesystem filesystem)
    {
        var assembly = Assembly.GetAssembly(typeof(VagrantfileResource));
        if (null == assembly) throw new InvalidOperationException("assembly is null");

        _filesystem = filesystem;

        _sourceVagrantfile = Path.Join(
            Path.GetDirectoryName(assembly.Location),
            "Resources",
            "Vagrant",
            Vagrantfile
        );
    }

    public void Copy(string? destination)
    {
        _filesystem
            .FileCopy(
                _sourceVagrantfile,
                Path.Join(destination, Vagrantfile)
            );
    }
}