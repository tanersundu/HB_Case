using Xunit;
using MarsMission.Rovers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMission.Core;

namespace MarsMission.Rovers.Tests
{
    public class BasicRoverTests
    {
        [Theory]
        [InlineData(5, 5, "N", "L", "5 5 W")]
        [InlineData(5, 5, "N", "R", "5 5 E")]
        [InlineData(5, 5, "N", "M", "5 6 N")]
        public void ProcessTest(int x, int y, string direction, string command, string result)
        {
            IRover rover = new BasicRover(x, y, direction);

            rover.Process(command);

            Assert.Equal(result, rover.GetLocationString());
        }

        [Theory]
        [InlineData(5, 5, "N", "X", "5 5 W")]
        [InlineData(5, 5, "N", null, "5 5 E")]
        public void ProcessTest_InvalidArgument(int x, int y, string direction, string command, string result)
        {
            IRover rover = new BasicRover(x, y, direction);

            Assert.Throws<NotImplementedException>(() => rover.Process(command));
        }

        [Fact()]
        public void GetLocationStringTest()
        {
            int initialX = 5;
            int initialY = 5;
            string initialDirection = "N";
            IRover rover = new BasicRover(initialX, initialY, initialDirection);

            rover.GetLocationString();

            string expectedResult = $"{initialX} {initialY} {initialDirection}";
            Assert.Equal(expectedResult, rover.GetLocationString());
        }
    }
}