using System;
using Xunit;

namespace GithubActionsTest.Tests
{
    public class MyTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.True(false);
        }
    }
}
