using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Core
{
    /// <summary>
    /// Interface to handle multiple directions
    /// </summary>
    public interface ICircularDirections
    {
        /// <summary>
        /// Turns the heading at specified angle. Positive values mean turning to the right, negatives mean turning to the left.
        /// </summary>
        void Turn(int angle);
        /// <summary>
        /// Sets heading to the direction defined by the direction text parameter. If the direction cannot be found, direction is set to North
        /// </summary>
        void SetDirectionFromText(string directionText);
        /// <summary>
        /// Gets the current direction text
        /// </summary>
        /// <returns></returns>
        string GetCurrentDirectionText();
        /// <summary>
        /// Moves the IRover in the current direction
        /// </summary>
        /// <param name="roverState"></param>
        void Move(IRoverState roverState);
    }
}
