using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FlyTestPuzzle.Tests
{
    public class JetTest
    {
        [Fact]
        public void ShouldCreateJet()
        {
            Jet jet = new();
        }

        [Fact]
        public void ShouldSetAndGetSpeed()
        {
            Jet jet = new();
            jet.SetSpeed(300);
            Assert.Equal(600, jet.GetSpeed());
        }

        [Fact]
        public void ShouldAccelerate()
        {
            Jet jet = new();
            jet.SetSpeed(300);
            jet.Accelerate();
            Assert.Equal(1200, jet.GetSpeed());
        }
    }
}
