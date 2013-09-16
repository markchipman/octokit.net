﻿using FluentAssertions;
using Octokit.Http;
using Xunit;

namespace Octokit.Tests.Http
{
    public class RequestTests
    {
        public class TheConstructor
        {
            [Fact]
            public void InitializesAllRequiredProperties()
            {
                var r = new Request();

                r.Headers.Should().NotBeNull();
            }
        }
    }
}