using Xunit;
using MarsMission.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMission.Core;

namespace MarsMission.States.Tests
{
    public class RoverStateTests
    {
        [Theory]
        [InlineData(1, 2, "N")]
        [InlineData(2, 1, "S")]
        [InlineData(0, 0, "E")]
        [InlineData(2, 2, "W")]
        public void RoverStateTest(int x, int y, string direction)
        {
            IRoverState roverState = new RoverState(x,y,direction);


            Assert.Equal(x, roverState.X);
            Assert.Equal(y, roverState.Y);
            Assert.Equal(direction, roverState.GetDirectionText());
        }

        [Theory]
        [InlineData(5, 5, "N", "5 6 N")]
        [InlineData(5, 5, "S", "5 4 S")]
        [InlineData(5, 5, "E", "6 5 E")]
        [InlineData(5, 5, "W", "4 5 W")]
        public void MoveTest(int x, int y, string direction, string resultingState)
        {
            IRoverState roverState = new RoverState(x, y, direction);

            roverState.Move();

            Assert.Equal(resultingState, roverState.GetState());
        }

        [Theory]
        [InlineData(5, 5, "N", "W")]
        [InlineData(5, 5, "E", "N")]
        [InlineData(5, 5, "S", "E")]
        [InlineData(5, 5, "W", "S")]
        public void TurnLeftTest(int x, int y, string initialDirection, string resultingDirection)
        {
            IRoverState roverState = new RoverState(x, y, initialDirection);

            roverState.TurnLeft();

            Assert.Equal(resultingDirection, roverState.GetDirectionText());
        }

        [Theory]
        [InlineData(5, 5, "N", "E")]
        [InlineData(5, 5, "E", "S")]
        [InlineData(5, 5, "S", "W")]
        [InlineData(5, 5, "W", "N")]
        public void TurnRightTest(int x, int y, string initialDirection, string resultingDirection)
        {
            IRoverState roverState = new RoverState(x, y, initialDirection);

            roverState.TurnRight();

            Assert.Equal(resultingDirection, roverState.GetDirectionText());
        }

        [Theory]
        [InlineData(1, 2, "N")]
        [InlineData(2, 1, "S")]
        [InlineData(0, 0, "E")]
        [InlineData(2, 2, "W")]
        public void GetDirectionTextTest(int x, int y, string direction)
        {
            IRoverState roverState = new RoverState(x, y, direction);

            Assert.Equal(direction, roverState.GetDirectionText());
        }

        [Theory]
        [InlineData(5, 5, "N", "5 5 N")]
        [InlineData(5, 5, "S", "5 5 S")]
        [InlineData(5, 5, "E", "5 5 E")]
        [InlineData(5, 5, "W", "5 5 W")]
        public void GetStateTest(int x, int y, string direction, string resultingState)
        {
            IRoverState roverState = new RoverState(x, y, direction);

            Assert.Equal(resultingState, roverState.GetState());
        }
    }
}