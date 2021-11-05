using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Core
{
    /// <summary>
    /// Rover state
    /// </summary>
    public interface IRoverState
    {
        /// <summary>
        /// Current X coordinate
        /// </summary>
        int X { get; set; }
        /// <summary>
        /// Current Y coordinate
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Move...
        /// </summary>
        void Move();
        /// <summary>
        /// Right turn ...
        /// </summary>
        void TurnRight();
        /// <summary>
        /// Left turn...
        /// </summary>
        void TurnLeft();
        /// <summary>
        /// Heading text
        /// </summary>
        /// <returns></returns>
        string GetDirectionText();
        /// <summary>
        /// Returns the current state in the format [X] [Y] [Direction]
        /// </summary>
        /// <returns></returns>
        string GetState();
    }
}
