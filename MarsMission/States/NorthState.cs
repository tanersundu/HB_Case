using MarsMission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States
{
    /// <summary>
    /// North direction state
    /// </summary>
    public class NorthState : IDirection
    {
        /// <inheritdoc />
        public string DirectionText => "N";

        /// <inheritdoc />
        public void Move(IRoverState state)
        {
            state.Y++;
        }

    }
}
