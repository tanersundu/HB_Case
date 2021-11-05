using MarsMission.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Core
{
    /// <summary>
    /// Interface for direction actions
    /// </summary>
    public interface IDirection
    {
        /// <summary>
        /// Moves the rover
        /// </summary>
        /// <param name="state">rover</param>
        void Move(IRoverState state);

        /// <summary>
        /// Direction text
        /// </summary>
        string DirectionText { get; }
    }
}
