using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    internal class AreaOfPoligon
    {
        public double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            double result = 0.5 * Math.Pow(circleRadius, 2) * numberOfSides * Math.Sin(2 * Math.PI/(double)numberOfSides);
            return Math.Round(result, 3);
        }
    }
}
