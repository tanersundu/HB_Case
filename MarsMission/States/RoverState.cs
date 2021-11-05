using MarsMission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States
{
    /// <summary>
    /// Tracking state of the rover.
    /// </summary>
    public class RoverState : IRoverState
    {
        /// <summary>
        /// Creates a new rover state
        /// </summary>
        public RoverState(int initialX, int initialY, string initialDirection)
        {
            X = initialX;
            Y = initialY;
            directions.SetDirectionFromText(initialDirection);
        }

        /// <inheritdoc />
        public int X { get; set; }
        /// <inheritdoc />
        public int Y { get; set; }
        private ICircularDirections directions = new CircularDirections4Angle();

        /// <inheritdoc />
        public void Move()
        {
            directions.Move(this);
        }

        /// <inheritdoc />
        public void TurnLeft()
        {
            directions.Turn(-1);
        }

        /// <inheritdoc />
        public void TurnRight()
        {
            directions.Turn(1);
        }

        /// <inheritdoc />
        public string GetDirectionText()
        {
            return directions.GetCurrentDirectionText();
        }

        /// <inheritdoc />
        public string GetState()
        {
            return $"{X} {Y} {directions.GetCurrentDirectionText()}";
        }
    }
}
