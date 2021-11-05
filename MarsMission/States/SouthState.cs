using MarsMission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States
{
    /// <summary>
    /// South direction state
    /// </summary>
    public class SouthState : IDirection
    {
        /// <inheritdoc />
        public string DirectionText => "S";

        /// <inheritdoc />
        public void Move(IRoverState state)
        {
            state.Y--;
        }
    }
}
