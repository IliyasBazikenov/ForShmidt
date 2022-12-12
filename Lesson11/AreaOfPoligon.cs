using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    internal class AreaOfPoligon
    {
        public double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            double result = (1/2) * Math.Pow(circleRadius, 2) * (double)numberOfSides * Math.Sin(360/(double)numberOfSides);
            Math.Round(result, 3);
            return result;
        }
    }
}
