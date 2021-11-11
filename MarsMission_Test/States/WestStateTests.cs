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
    public class WestStateTests
    {
        [Fact()]
        public void MoveTest()
        {
            IRoverState state = new RoverState(5, 5, "W");
            IDirection direction = new WestState();

            direction.Move(state);

            Assert.Equal(4, state.X);
            Assert.Equal(5, state.Y);
        }

        [Fact]
        public void DirectionTextTest()
        {
            IDirection direction = new WestState();

            Assert.Equal("W", direction.DirectionText);
        }
    }
}