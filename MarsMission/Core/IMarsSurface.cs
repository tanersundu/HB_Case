using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Core
{
    /// <summary>
    /// Defines a mars surface area
    /// </summary>
    public interface IMarsSurface
    {
        /// <summary>
        /// Added for simplicity, prefer to use <see cref="AddRover(IRover)"/> method
        /// Adds a new rover on the surface
        /// </summary>
        /// <param name="initialX">Starting X coordinate</param>
        /// <param name="initialY">Starting Y coordinate</param>
        /// <param name="initialDirection">Starting initial direction of the rover</param>
        void AddRover(int initialX, int initialY, string initialDirection);

        /// <summary>
        /// Adds a new rover to the surface...
        /// </summary>
        /// <param name="rover"></param>
        void AddRover(IRover rover);

        /// <summary>
        /// Sends exploring commands to last added rover.
        /// </summary>
        /// <param name="commands"></param>
        void ExploreWithLastRover(string commands);

        /// <summary>
        /// Gets all rover coordinates as one line for each rover
        /// </summary>
        /// <returns></returns>
        string GetAllRoverCoordinates();
    }
}
