using System;
using Xunit;
using FlyTestPuzzle;

namespace FlyTestPuzzle.Tests
{
    public class FlyTestTest
    {
        [Fact]
        public void ShouldRunFlyTest()
        {
            string[] args = { };
            FlyTest.Main(args);
        }
    }
}
