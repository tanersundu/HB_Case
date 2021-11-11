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
    public class NorthStateTests
    {
        [Fact()]
        public void MoveTest()
        {
            IRoverState state = new RoverState(5, 5, "N");
            IDirection direction = new NorthState();

            direction.Move(state);

            Assert.Equal(5, state.X);
            Assert.Equal(6, state.Y);
        }

        [Fact]
        public void DirectionTextTest()
        {
            IDirection direction = new NorthState();

            Assert.Equal("N", direction.DirectionText);
        }
    }
}