using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    internal class Rectangle
    {
        private Point2D _topLeft;
        private Point2D _bottomRight;

        public Rectangle(Point2D leftTop, Point2D rightBottom)
        {
            _topLeft = leftTop;
            _bottomRight = rightBottom;
        }

        public Rectangle(int xLeft, int yTop, int xRight, int yBottom)
            : this(new Point2D(xLeft, yTop), new Point2D(xRight, yBottom))
        {}

        public Rectangle(int length, int width)
            : this(new Point2D(0, width), new Point2D(length, 0))
        {}

        public Rectangle()
            : this(new Point2D(0, 1), new Point2D(1, 0))
        {}

        public Point2D GetTopLeft() => _topLeft;

        public Point2D GetBottomRight() => _bottomRight;

        public void SetTopLeft(Point2D topLeft) => _topLeft = topLeft;

        public void SetBottomRight(Point2D bottomRight) => _bottomRight = bottomRight;

        public int GetLength()
        {
            return _bottomRight.GetX() - _topLeft.GetX();
        }

        public int GetWidth()
        {
            return _topLeft.GetY() - _bottomRight.GetY();
        }

        public void MoveRel(int dx, int dy)
        {
           _topLeft.MoveRel(dx, dy);
           _bottomRight.MoveRel(dx, dy);
        }

        public void Enlarge(int nx, int ny)
        {
            _bottomRight.SetX(_bottomRight.GetX() * nx);

            _bottomRight.SetY(_topLeft.GetY() - (GetWidth()*ny));
        }

        public double GetArea()
        {
            return GetLength() * GetWidth();
        }

        public double GetPerimeter()
        {
            return (GetLength() + GetWidth()) * 2;
        }

        //Починить!
        public bool IsInside(int x, int y)
        {
            if (x >= _topLeft.GetX() && y >= _topLeft.GetY() && x >= _bottomRight.GetX() && y >= _bottomRight.GetY())
                return false;

            return true;
        }

        public bool IsInside(Point2D point)
        {
            return IsInside(point.GetX(), point.GetY());
        }

        public bool IsIntersects(Rectangle rectangle)
        {

            bool recTopLeftIntersec = _topLeft.GetX() <= rectangle.GetBottomRight().GetX() && _topLeft.GetY() >= rectangle.GetBottomRight().GetY() && _bottomRight.GetX() >= rectangle.GetTopLeft().GetX();
            bool recBotRightIntersec = _bottomRight.GetX() >= rectangle.GetTopLeft().GetX() && _bottomRight.GetY() <= rectangle.GetTopLeft().GetY() && _bottomRight.GetX() <= rectangle.GetBottomRight().GetX() ; 
            return recTopLeftIntersec || recBotRightIntersec;
        }

        public bool IsInside(Rectangle rectangle)
        {
            return  IsInside(rectangle.GetTopLeft()) && IsInside(rectangle.GetBottomRight());
        }
            
    }
}
