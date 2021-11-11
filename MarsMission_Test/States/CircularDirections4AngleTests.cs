using Xunit;
using MarsMission.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States.Tests
{
    public class CircularDirections4AngleTests
    {
        [Theory]
        [InlineData(1, "E")]
        [InlineData(-1, "W")]
        [InlineData(5, "E")]
        [InlineData(-5, "W")]
        public void TurnTest(int angle, string resultingDirection)
        {
            CircularDirections4Angle item = new CircularDirections4Angle();

            item.Turn(angle);

            Assert.Equal(resultingDirection, item.GetCurrentDirectionText());
        }

        [Theory]
        [InlineData("N")]
        [InlineData("E")]
        [InlineData("S")]
        [InlineData("W")]
        public void SetDirectionFromTextTest(string direction)
        {
            CircularDirections4Angle item = new CircularDirections4Angle();

            item.SetDirectionFromText(direction);

            Assert.Equal(direction, item.GetCurrentDirectionText());
        }
    }
}