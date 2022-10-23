using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    internal class Circle
    {
        private Point2D _center;
        private int _radius;

        public Circle(Point2D center, int radius)
        {
            _center = center;
            _radius = radius;
        }

        public Circle(int xCenter, int yCenter, int radius)
             : this(new Point2D(xCenter, yCenter), radius)
        {}

        public Circle(int radius)
            : this(0, 0, radius)
        {}

        public Circle()
            : this(0, 0, 1)
        {}

        public Point2D GetCenter() => _center;

        public int GetRadius() => _radius;

        public void SetCenter(Point2D center)
        {
            _center = center;
        }

        public void SetRadius(int radius)
        {
            _radius = radius;
        }

        public void MoveRel(int dx, int dy)
        {
            _center.MoveRel(dx, dy);
        }

        public void Enlarge(int n)
        {
            _radius *= n; 
        }

        public double GetArea()
        {
           return _radius * 3.14;
        }

        public double GetPerimeter()
        {
           return 2 * _radius * 3.14;
        }

        public bool IsInside(int x, int y)
        {
            if (x >= _center.GetX() + _radius && x >= _center.GetY() + _radius)
                return false;

            return true;
        }
        public bool IsInside(Point2D point)
        {
            if (point >= _center.GetX() + _radius && point >= _center.GetY() + _radius);
        }
    }
}
