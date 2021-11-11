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
    public class EastStateTests
    {
        [Fact()]
        public void MoveTest()
        {
            IRoverState state = new RoverState(5, 5, "E");
            IDirection direction = new EastState();

            direction.Move(state);

            Assert.Equal(6, state.X);
            Assert.Equal(5, state.Y);
        }

        [Fact]
        public void DirectionTextTest()
        {
            IDirection direction = new EastState();

            Assert.Equal("E", direction.DirectionText);
        }
    }
}