using MarsMission.Core;
using MarsMission.Rovers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Surfaces
{
    /// <summary>
    /// Defines a rectangular mars surface area.
    /// </summary>
    public class RectangularMarsSurface : IMarsSurface
    {
        /// <summary>
        /// Creates a new instance of rectangular surface grid
        /// </summary>
        public RectangularMarsSurface(int x, int y, bool checkLimits = false)
        {
            X = x;
            Y = y;
            _checkLimits = checkLimits;
        }

        /// <summary>
        /// Max X coordinate of the surface.
        /// </summary>
        public int X { get; private set; }
        /// <summary>
        /// Max Y coordinate of the surface
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// Will be used to check limits.
        /// </summary>
        private bool _checkLimits;
        private List<IRover> _rovers = new List<IRover>();
        private IRover _currentRover;

        public void AddRover(int initialX, int initialY, string initialDirection)
        {
            // TODO: TS - Check whether coordinates are valid.
            _currentRover = new BasicRover(initialX, initialY, initialDirection);
            _rovers.Add(_currentRover);
        }

        /// <summary>
        /// Sends Commands to last added rover to explore surface.
        /// </summary>
        /// <param name="commands">Multiple command characters as a string. Currently valid values are any combination of chars 'L', 'R', 'M'</param>
        /// <exception cref="NotImplementedException">Thrown when invalid command is sent or no rover is defined...</exception>
        public void ExploreWithLastRover(string commands)
        {
            if (string.IsNullOrWhiteSpace(commands))
                throw new NotImplementedException("Invalid command sequence");
            // TODO: TS - Check & handle no rover defined case.
            if (_currentRover is null)
                throw new NotImplementedException("Throw Exception No Rover Defined");

            // TODO: TS - Do we need to check if the place the rover goes is already occupied with another rover?
            // If yes provide surface reference to rovers to check availability of the coordinates.
            foreach (char item in commands)
                _currentRover.Process(item.ToString());
        }

        /// <inheritdoc />
        public void AddRover(IRover rover)
        {
            throw new NotSupportedException("Not supported in this version :)");
        }

        /// <inheritdoc />
        public string GetAllRoverCoordinates()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in _rovers)
            {
                sb.AppendLine(item.GetLocationString());
            }
            return sb.ToString();
        }
    }
}
