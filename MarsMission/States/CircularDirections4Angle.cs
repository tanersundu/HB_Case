using MarsMission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States
{
    /// <summary>
    /// Defines a Circular direction concreate implementation in 4 angles.
    /// N, E, S, W
    /// </summary>
    public class CircularDirections4Angle : ICircularDirections
    {
        public CircularDirections4Angle()
        {
            _items.Add(new NorthState());
            _items.Add(new EastState());
            _items.Add(new SouthState());
            _items.Add(new WestState());
        }

        private List<IDirection> _items = new List<IDirection>();
        private int _currentIndex = 0;

        /// <inheritdoc />
        public void Turn(int angle)
        {
            int index = _currentIndex + angle;
            while (index < 0)
                index += _items.Count;
            _currentIndex = index % _items.Count;
        }

        /// <inheritdoc />
        public void SetDirectionFromText(string directionText)
        {
            var item = _items.FirstOrDefault(p => p.DirectionText == directionText);
            if (item is null)
                item = _items.First();
            _currentIndex = _items.IndexOf(item);
        }

        /// <inheritdoc />
        public string GetCurrentDirectionText()
        {
            return _items[_currentIndex].DirectionText;
        }

        /// <inheritdoc />
        public void Move(IRoverState roverState)
        {
            _items[_currentIndex].Move(roverState);
        }
    }

    
}
