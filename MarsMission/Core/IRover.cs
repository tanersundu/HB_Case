using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Core
{
    /// <summary>
    /// Rover interface.
    /// </summary>
    public interface IRover
    {
        /// <summary>
        /// Processes commands that rover should handle.
        /// </summary>
        /// <param name="command"></param>
        void Process(string command);
        /// <summary>
        /// Gets location text of the rover
        /// </summary>
        /// <returns>Location string in the format of <![CDATA["<X coordinate> <Y coordinate> <direction string>"]]></returns>
        string GetLocationString();
    }
}
