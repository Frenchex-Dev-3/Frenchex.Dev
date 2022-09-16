﻿using Frenchex.Dev.Dotnet.Core.Filesystem.Lib.Domain;
using Frenchex.Dev.Dotnet.Core.UnitTesting.Lib.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Frenchex.Dev.Dotnet.Core.Filesystem.Lib.Tests;

[TestClass]
public class FileSystemCreateDirectoryTests : AbstractUnitTest
{
    [TestInitialize]
    public void CreateUnitTest()
    {
        UnitTest = FilesystemUnitTestBase.CreateNewUnitTest<ExecutionContext>();
    }

    public static IEnumerable<object[]> DataSource()
    {
        yield return new object[] {Path.Join("Resources")};
    }

    [TestMethod]
    [DynamicData(nameof(DataSource), DynamicDataSourceType.Method)]
    public async Task CanCreateDirectory(string originalFile)
    {
        await UnitTest!.RunAsync<ExecutionContext>(async (provider, root, context, vsCode) =>
            {
                var fs = provider.GetRequiredService<IFilesystem>();

                var originalFileName = Path.GetFileName(originalFile);
                context.FullDestinationDirectory = Path.Join(Path.GetTempPath(), originalFileName);

                await Task.Run(() =>
                {
                    fs.DirectoryCreate(context.FullDestinationDirectory);
                });
            },
            async (provider, root, context) =>
            {
                await Task.Run(() =>
                {
                    Assert.IsTrue(Directory.Exists(context.FullDestinationDirectory));
                });
            },
            async (provider, root, context) =>
            {
                await Task.Run(() =>
                {
                    var fileToDelete = context.FullDestinationDirectory;
                    Directory.Delete(fileToDelete!, true);
                });
            }
        );
    }

    private class ExecutionContext : WithWorkingDirectoryExecutionContext
    {
        public string? FullDestinationDirectory { get; set; }
    }
}