using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    internal class Rectangle
    {
        private Point2D _leftTop;
        private Point2D _rightBottom;

        public Rectangle(Point2D leftTop, Point2D rightBottom)
        {
            _leftTop = leftTop;
            _rightBottom = rightBottom;
        }
        public Rectangle(int xLeft, int yTop, int xRight, int yBottom)
            : this(new Point2D(xLeft, yTop), new Point2D(xRight, yBottom))
        {
            
        }

        private Point2D _leftBottom;
        private int _length;
        private int _width;

        public Rectangle(int length, int width)
        {
            _leftBottom = new Point2D(0, 0);
            _length = length;
            _width = width;
        }

        public Rectangle()
        {
            _leftBottom = new Point2D(0, 0);
            _length = 1;
            _width = 1;
        }

        public Point2D GetTopLeft()
        {
            return _leftTop;
        }

        public Point2D GetBottomRight()
        {
            return _rightBottom;
        }

        public void SetTopLeft(Point2D topLeft)
        {
            this._leftTop = topLeft;
        }

        public void SetBottomRight(Point2D bottomRight)
        {
            this._rightBottom = bottomRight;
        }

        public int GetLength()
        {
            return _length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void MoveRel(int dx, int dy)
        {
           
        }


    }
}
