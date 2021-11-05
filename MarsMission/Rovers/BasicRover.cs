using MarsMission.Core;
using MarsMission.States;
using System;

namespace MarsMission.Rovers
{
    /// <inheritdoc />
    public class BasicRover : IRover
    {
        /// <summary>
        /// Creates a new rover instance with initial location.
        /// </summary>
        /// <param name="initialX"> ... </param>
        /// <param name="initialY"> ... </param>
        /// <param name="initialDirection"> ... </param>
        public BasicRover(int initialX, int initialY, string initialDirection)
        {
            state = new RoverState(initialX, initialY, initialDirection);
        }

        private IRoverState state;
        
        // TODO: TS - Add if we need to check boundries.
        // private IMarsSurface _marsSurface;

        /// <inheritdoc />
        public void Process(string command)
        {
            // TODO: TS - Handle commands more structurally
            switch (command)
            {
                case "L":
                    state.TurnLeft();
                    break;
                case "R":
                    state.TurnRight();
                    break;
                case "M":
                    state.Move();
                    break;
                default:
                    // TODO: TS - What if invalid command is send
                    throw new NotImplementedException("Invalid command entered.");
            }
        }

        /// <inheritdoc />
        public string GetLocationString()
        {
            return state.GetState();
        }
    }
}
