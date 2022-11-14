using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    public class Triangle
    {
        private Point2D _point1;
        private Point2D _point2;
        private Point2D _point3;
        public Triangle(Point2D point1, Point2D point2, Point2D point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        public Point2D GetPoint1()
        {
            return _point1;
        }

        public Point2D GetPoint2()
        {
            return _point2;
        }

        public Point2D GetPoint3()
        {
            return _point3;
        }

        public void SetPoint1(Point2D point)
        {
            _point1 = point;
        }

        public void SetPoint2(Point2D point)
        {
            _point2 = point;
        }

        public void SetPoint3(Point2D point)
        {
            _point3= point;
        }

        public double GetSide12()
        {
            double side12 = Math.Pow(_point2.GetX() - _point1.GetX(), 2) + Math.Pow(_point2.GetY() - _point1.GetY(), 2);
            return Math.Sqrt(Math.Abs(side12));

        }

        public double GetSide13()
        {
            double side13 = Math.Pow(_point3.GetX() - _point1.GetX(), 2) + Math.Pow(_point3.GetY() - _point1.GetY(), 2);
            return Math.Sqrt(Math.Abs(side13));
        }

        public double GetSide23()
        {
            double side23 = Math.Pow(_point2.GetX() - _point3.GetX(), 2) + Math.Pow(_point2.GetY() - _point3.GetY(), 2);
            return Math.Sqrt(Math.Abs(side23));
        }

        public void MoveRel(int dx, int dy)
        {
            _point1.MoveRel(dx, dy);
            _point2.MoveRel(dx, dy);
            _point3.MoveRel(dx, dy);
        }

        public double GetArea()
        {
            return (double)Math.Abs((_point2.GetX() - _point1.GetX()) * (_point3.GetY() - _point1.GetY()) - (_point3.GetX() - _point1.GetX()) * (_point2.GetY() - _point1.GetY()))/2;
        }

        public double GetPerimeter()
        {
            return GetSide12() + GetSide13() + GetSide23();
        }

        public bool IsInside(int x, int y)
        {
            Triangle triangleOne = new Triangle(new Point2D(x, y), _point2, _point3);
            Triangle triangleTwo = new Triangle(_point1, new Point2D(x, y), _point3);
            Triangle triangleThree = new Triangle(_point1, _point2, new Point2D(x, y));

            double area = triangleOne.GetArea() + triangleTwo.GetArea() + triangleThree.GetArea();
            return area == GetArea();
        }
    }
}
