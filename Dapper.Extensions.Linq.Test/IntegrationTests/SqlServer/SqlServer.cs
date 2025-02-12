﻿using Dapper.Extensions.Linq.Test.IntegrationTests.Fixtures;
using NUnit.Framework;

namespace Dapper.Extensions.Linq.Test.IntegrationTests.SqlServer
{
    public class SqlServer : FixturesBase
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Container = SqlSetup.Configuration();
        }
    }
}