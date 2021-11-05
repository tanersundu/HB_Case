using MarsMission.Core;
using MarsMission.Surfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace HB_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample input
            string strTest = @"15 15
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM
5 5 N
MMMMRMMLMMLMM
";

            string[] lines = strTest.Split(Environment.NewLine);
            var coordinates = lines[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            // TODO: TS - Factory
            IMarsSurface surface = new RectangularMarsSurface(Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]));
            
            for (int i = 1; i<lines.Count(); i+=2)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    break;
                var initialValues = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                surface.AddRover(Convert.ToInt32(initialValues[0]), Convert.ToInt32(initialValues[1]), initialValues[2]);
                surface.ExploreWithLastRover(lines[i + 1]);
            }

            Console.WriteLine(surface.GetAllRoverCoordinates());
        }
    }
}
