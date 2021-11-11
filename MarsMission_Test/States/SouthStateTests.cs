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
    public class SouthStateTests
    {
        [Fact()]
        public void MoveTest()
        {
            IRoverState state = new RoverState(5, 5, "S");
            IDirection direction = new SouthState();

            direction.Move(state);

            Assert.Equal(5, state.X);
            Assert.Equal(4, state.Y);
        }

        [Fact]
        public void DirectionTextTest()
        {
            IDirection direction = new SouthState();

            Assert.Equal("S", direction.DirectionText);
        }
    }
}