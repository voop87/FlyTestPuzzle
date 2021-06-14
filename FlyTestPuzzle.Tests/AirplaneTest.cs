using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FlyTestPuzzle.Tests
{
    public class AirplaneTest
    {
        [Fact]
        public void ShouldCreateAirplane()
        {
            Airplane airplane = new();
        }

        [Fact]
        public void ShouldSetAndGetSpeed()
        {
            Airplane airplane = new();
            airplane.SetSpeed(200);

            Assert.Equal(200, airplane.GetSpeed());
        }

        [Fact]
        public void ShouldAccelerate()
        {
            Airplane airplane = new();
            airplane.SetSpeed(200);
            airplane.Accelerate();

            Assert.Equal(400, airplane.GetSpeed());
        }
    }
}
