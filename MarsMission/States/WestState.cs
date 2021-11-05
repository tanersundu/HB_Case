using MarsMission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States
{
    /// <summary>
    /// West direction state
    /// </summary>
    public class WestState : IDirection
    {
        /// <inheritdoc />
        public string DirectionText => "W";

        /// <inheritdoc />
        public void Move(IRoverState state)
        {
            state.X--;
        }
    }
}
