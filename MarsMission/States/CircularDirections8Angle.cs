using MarsMission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.States
{
    /// <summary>
    /// Defines a Circular direction concreate implementation in 8 angles.
    /// N, NE, E, SE, S, SW, W, NW
    /// </summary>
    public class CircularDirections8Angle : ICircularDirections
    {
        public CircularDirections8Angle()
        {
            _items.Add(new List<IDirection> { new NorthState() });
            _items.Add(new List<IDirection> { new NorthState(), new EastState() });
            _items.Add(new List<IDirection> { new EastState() });
            _items.Add(new List<IDirection> { new SouthState(), new EastState() });
            _items.Add(new List<IDirection> { new SouthState() });
            _items.Add(new List<IDirection> { new SouthState(), new WestState() });
            _items.Add(new List<IDirection> { new WestState() });
            _items.Add(new List<IDirection> { new NorthState(), new WestState() });
        }

        private List<List<IDirection>> _items = new List<List<IDirection>>();
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
            var item = _items.FirstOrDefault(p => string.Join("", p.Select(q => q.DirectionText)) == directionText);
            if (item is null)
                item = _items.First();
            _currentIndex = _items.IndexOf(item);
        }

        /// <inheritdoc />
        public string GetCurrentDirectionText()
        {
            string directionText = string.Empty;
            foreach (var item in _items[_currentIndex])
            {
                directionText += item.DirectionText;
            }
            return directionText;
        }

        /// <inheritdoc />
        public void Move(IRoverState roverState)
        {
            var currentDirections = _items[_currentIndex];
            foreach (var item in currentDirections)
            {
                item.Move(roverState);
            }
        }
    }
}
