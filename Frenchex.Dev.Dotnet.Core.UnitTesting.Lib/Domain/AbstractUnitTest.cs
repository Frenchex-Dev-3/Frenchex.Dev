﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Frenchex.Dev.Dotnet.Core.UnitTesting.Lib.Domain;

[TestClass]
public abstract class AbstractUnitTest
{
    protected UnitTest? UnitTest;

    [TestCleanup]
    public async Task InstanceCleanup()
    {
        if (UnitTest is not null)
        {
            await UnitTest.DisposeAsync();
        }
    }
}