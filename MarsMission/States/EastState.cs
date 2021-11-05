using MarsMission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States
{
    /// <summary>
    /// East direction state
    /// </summary>
    public class EastState : IDirection
    {
        /// <inheritdoc />
        public string DirectionText => "E";

        /// <inheritdoc />
        public void Move(IRoverState state)
        {
            state.X++;
        }
    }
}
